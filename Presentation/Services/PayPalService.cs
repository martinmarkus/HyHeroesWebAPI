using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HyHeroesWebAPI.Presentation.DTOs.PayPalDTOs;
using HyHeroesWebAPI.Presentation.DTOs.PayPalOrderDTOs;
using JsonSerializer = System.Text.Json.JsonSerializer;
using HyHeroesWebAPI.Infrastructure.Infrastructure.ConfigObjects;
using Microsoft.Extensions.Options;
using HyHeroesWebAPI.Infrastructure.Persistence.UnitOfWork;
using HyHeroesWebAPI.Presentation.Mappers.Interfaces;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.ApplicationCore.Enums;
using HyHeroesWebAPI.Presentation.DTOs.BillingoDTOs;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class PayPalService : IPayPalService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IPayPalOrderRepository _payPalOrderRepository;
        private readonly IUserRepository _userRepository;
        private readonly IPayPalBillingAddressRepository _payPalBillingAddressRepository;

        private readonly IPayPalTokenService _payPalTokenService;
        private readonly INotificationService _notificationService;
        private readonly IBillingoService _billingoService;

        private readonly IPayPalMapper _payPalMapper;

        private readonly ILogger<object> _logger;
        private readonly IOptions<AppSettings> _options;


        public PayPalService(
            IPayPalMapper payPalMapper,
            IUnitOfWork unitOfWork,
            IPayPalOrderRepository payPalOrderRepository,
            IPayPalTokenService payPalTokenService,
            INotificationService notificationService,
            IBillingoService billingoService,
            IPayPalBillingAddressRepository payPalBillingAddressRepository,
            IUserRepository userRepository,
            ILogger<object> logger,
            IOptions<AppSettings> options)
        {
            _payPalMapper = payPalMapper ?? throw new ArgumentException(nameof(payPalMapper));
            _unitOfWork = unitOfWork ?? throw new ArgumentException(nameof(unitOfWork));

            _payPalTokenService = payPalTokenService ?? throw new ArgumentException(nameof(payPalTokenService));
            _notificationService = notificationService ?? throw new ArgumentException(nameof(notificationService));
            _billingoService = billingoService ?? throw new ArgumentException(nameof(billingoService));

            _payPalBillingAddressRepository = payPalBillingAddressRepository ?? throw new ArgumentException(nameof(payPalBillingAddressRepository));
            _payPalOrderRepository = payPalOrderRepository ?? throw new ArgumentException(nameof(payPalOrderRepository));
            _userRepository = userRepository ?? throw new ArgumentException(nameof(userRepository));

            _logger = logger ?? throw new ArgumentException(nameof(logger));
            _options = options ?? throw new ArgumentException(nameof(options));
        }

        public async Task<PayPalOrderResponseDTO> CreatePayPalTransactionAsync(
            string authenticatedUserName,
            PayPalTransactionDTO payPalTransactionDTO)
        {
            var user = await _userRepository.GetByUserNameAsync(authenticatedUserName);
            if (user == null)
            {
                throw new UnauthorizedAccessException();
            }

            var token = await _payPalTokenService.GetToken();
            if (token == null)
            {
                throw new InvalidTokenException();
            }

            var currencyValue = -1;

            foreach (var payPalType in _options.Value.PayPalPurchaseTypes)
            {
                if (payPalType.KreditValue == Convert.ToInt32(payPalTransactionDTO.KreditAmount))
                {
                    currencyValue = payPalType.GrossPrice;
                    break;
                }
            }
            if (currencyValue < 0)
            {
                throw new NotFoundException();
            }

            var createdOrder = new PayPalOrderDTO
            {
                intent = "CAPTURE",
                purchase_units = new List<PayPalCreateOrderUnitDTO>
                {
                    new PayPalCreateOrderUnitDTO
                    {
                        amount = new PayPalCreateOrderAmountDTO
                        {
                            currency_code = "HUF",
                            value = currencyValue.ToString()
                        },
                        description = payPalTransactionDTO.KreditAmount + " Kredit"
                    }
                }
            };

            var payPalOrder = default(PayPalOrder);
            try
            {
                var verificationRequest = WebRequest.Create("https://api-m.sandbox.paypal.com/v2/checkout/orders");
                verificationRequest.Method = "POST";
                verificationRequest.ContentType = "application/json";
                verificationRequest.Headers.Add(
                    "Authorization",
                    "Bearer " + token.Token);

                string strRequest = JsonSerializer.Serialize(createdOrder);
                verificationRequest.ContentLength = strRequest.Length;

                await using (var writer = new StreamWriter(await verificationRequest.GetRequestStreamAsync(), Encoding.ASCII))
                {
                    await writer.WriteAsync(strRequest);
                }

                using (var reader = new StreamReader(verificationRequest.GetResponse().GetResponseStream()))
                {
                    var response = await reader.ReadToEndAsync();
                    try
                    {
                        var jsonSerializerSettings = new JsonSerializerSettings();
                        jsonSerializerSettings.MissingMemberHandling = MissingMemberHandling.Ignore;
                        payPalOrder = JsonConvert.DeserializeObject<PayPalOrder>(response, jsonSerializerSettings);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        throw new InvalidIPNBodyException();
                    }
                }

                if (payPalOrder == null)
                {
                    throw new InvalidIPNBodyException();
                }
                payPalOrder.UserId = user.Id;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                _logger.LogError(e.Message);
                throw new InvalidIPNBodyException();
            }

            payPalOrder.BillingEmail = payPalTransactionDTO.BillingEmail;
            payPalOrder.BillingName = payPalTransactionDTO.BillingName;
            payPalOrder.TaxNumber = payPalTransactionDTO.TaxNumber;
            payPalOrder.KreditAmount = Convert.ToInt32(payPalTransactionDTO.KreditAmount);
            payPalOrder.CurrencyValue = currencyValue;

            payPalOrder.TaxNumber = payPalTransactionDTO.TaxNumber;
            var addedOrder = await _payPalOrderRepository.AddAsync(payPalOrder);

            await _payPalBillingAddressRepository.AddAsync(new PayPalBillingAddress()
            {
                City = payPalTransactionDTO.PayPalBillingAddress.City,
                Country = payPalTransactionDTO.PayPalBillingAddress.Country,
                Street = payPalTransactionDTO.PayPalBillingAddress.Street,
                Zip = payPalTransactionDTO.PayPalBillingAddress.Zip,
                PayPalOrderId = addedOrder.Id,
            });

            return new PayPalOrderResponseDTO
            { 
                Id = addedOrder.OrderId
            };
        }

        public async Task VerifyPaymentsAsync(string bodyJson)
        {
            var jsonSerializerSettings = new JsonSerializerSettings
            {
                MissingMemberHandling = MissingMemberHandling.Ignore
            };
            _logger.LogInformation("PAYMENT: JSON: " + bodyJson);
            try
            {
                var payment = JsonConvert.DeserializeObject<PayPalCaptureDTO>(bodyJson, jsonSerializerSettings);
                if (payment == null)
                {
                    throw new InvalidIPNBodyException();
                }
                var transaction = _unitOfWork.BeginTransaction();
                try
                {
                    payment.PayPalResource.PurchaseUnits.ForEach(unit =>
                    {
                        unit.Payments.Captures.ForEach(async capture =>
                        {
                            await VerifySinglePaymentAsync(payment.PayPalResource.Id, capture);
                        });
                    });

                    var order = await _payPalOrderRepository.GetUnfinisheByOrderIdAsync(payment.PayPalResource.Id);
                    var user = await _userRepository.GetByIdAsync(order.UserId);

                    await _unitOfWork.KreditPurchaseRepository.AddAsync(new KreditPurchase()
                    {
                        KreditValue = order.KreditAmount,
                        CurrencyValue = order.CurrencyValue,
                        PaymentType = PaymentType.PayPal,
                        UserId = order.UserId
                    });

                    await _billingoService.CreateBillAsync(new CreateBillingoBillDTO()
                    {
                        KreditValue = order.KreditAmount,
                        CurrencyValue = order.CurrencyValue,
                        ClientName = order.BillingName,
                        ClientEmail = order.BillingEmail,
                        PaymentType = "PayPal",
                        CountryCode = order.PayPalBillingAddress.Country,
                        ZipCode = order.PayPalBillingAddress.Zip.ToString(),
                        City = order.PayPalBillingAddress.City,
                        Address = order.PayPalBillingAddress.Street,
                        Taxnumber = order.TaxNumber,
                        UserName = user.UserName
                    });

                    await _notificationService.CreateInvoiceNotificationAsync(order.UserId, order.BillingEmail);
                    transaction.Commit();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    _logger.LogError(e.Message);
                    transaction.Rollback();
                    transaction.Dispose();
                }
                transaction.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                _logger.LogError(e.Message);
                throw e;
            }
        }

        private async Task VerifySinglePaymentAsync(string orderId, PayPalPaymentCaptureDTO capture)
        {
            try
            {
                if (capture.Status.Equals("COMPLETED", StringComparison.OrdinalIgnoreCase))
                {
                    _logger.LogInformation("PAYMENT: Not completed");
                    return;
                }

                var order = await _payPalOrderRepository.GetUnfinisheByOrderIdAsync(orderId);
                if (order == null)
                {
                    _logger.LogInformation("PAYMENT: Order in database not found: " + orderId);
                    return;
                }

                var user = await _userRepository.GetByIdAsync(order.UserId);
                if (user == null)
                {
                    _logger.LogInformation("PAYMENT: User not found");
                    return;
                }

                var requestedOrder = await RequestPayPalOrderByIdAsync(orderId);
                if (requestedOrder == null)
                {
                    _logger.LogInformation("PAYMENT: Order from paypal returned null: " + JsonSerializer.Serialize(capture));
                    return;
                }
                
                if (requestedOrder.Status.Equals("COMPLETED", StringComparison.OrdinalIgnoreCase))
                {
                    _logger.LogInformation("PAYMENT: Order from paypal has not been completed: " + JsonSerializer.Serialize(requestedOrder));
                    return;
                }

                user.Currency += (int)Math.Round(double.Parse(capture.Amount.Value));
                await _userRepository.SaveChangesAsync();

                order.IsFinished = true;
                await _payPalOrderRepository.UpdateAsync(order);
                _logger.LogInformation("PAYMENT: Done");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                _logger.LogError("PAYMENT: ERROR: " + e.Message);
                throw e;
            }
        }

        private async Task<PayPalOrder> RequestPayPalOrderByIdAsync(string id)
        {
            var token = await _payPalTokenService.GetToken();
            if (token == null)
            {
                throw new InvalidTokenException();
            }

            PayPalOrder payPalOrder = null;
            try
            {
                var verificationRequest = WebRequest.Create("https://api-m.sandbox.paypal.com/v2/checkout/orders/" + id);
                verificationRequest.Method = "GET";
                verificationRequest.ContentType = "application/json";
                verificationRequest.Headers.Add(
                    "Authorization",
                    "Bearer " + token.Token);

                using var reader = new StreamReader(verificationRequest.GetResponse().GetResponseStream());
                var response = await reader.ReadToEndAsync();
                var jsonSerializerSettings = new JsonSerializerSettings();
                jsonSerializerSettings.MissingMemberHandling = MissingMemberHandling.Ignore;
                payPalOrder = JsonConvert.DeserializeObject<PayPalOrder>(response, jsonSerializerSettings);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                _logger.LogError("PAYMENT: REQUEST PAYPAL ERROR: " + e.Message);
                throw e;
            }

            return payPalOrder;
        }

        public PayPalPurchaseTypeListDTO GetPayPalPurchaseTypes() =>
            _payPalMapper.MapToPayPalPurchaseTypeListDTO(_options.Value.PayPalPurchaseTypes);
    }
}

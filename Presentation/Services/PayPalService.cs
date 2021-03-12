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
using HyHeroesWebAPI.ApplicationCore.DataObjects;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class PayPalService : IPayPalService
    {
        private readonly IPayPalOrderRepository _payPalOrderRepository;
        private readonly IUserRepository _userRepository;
        private readonly IPayPalBillingAddressRepository _payPalBillingAddressRepository;
        private readonly IKreditPurchaseRepository _kreditPurchaseRepository;

        private readonly IPayPalTokenService _payPalTokenService;
        private readonly INotificationService _notificationService;
        private readonly IBillingoService _billingoService;
        private readonly IDiscordService _discordService;

        private readonly IPayPalMapper _payPalMapper;

        private readonly ILogger<object> _logger;
        private readonly IOptions<AppSettings> _options;

        public PayPalService(
            IPayPalMapper payPalMapper,
            IPayPalOrderRepository payPalOrderRepository,
            IKreditPurchaseRepository kreditPurchaseRepository,
            IPayPalTokenService payPalTokenService,
            INotificationService notificationService,
            IBillingoService billingoService,
            IDiscordService discordService,
            IPayPalBillingAddressRepository payPalBillingAddressRepository,
            IUserRepository userRepository,
            ILogger<object> logger,
            IOptions<AppSettings> options)
        {
            _payPalMapper = payPalMapper ?? throw new ArgumentException(nameof(payPalMapper));
           
            _payPalTokenService = payPalTokenService ?? throw new ArgumentException(nameof(payPalTokenService));
            _notificationService = notificationService ?? throw new ArgumentException(nameof(notificationService));
            _billingoService = billingoService ?? throw new ArgumentException(nameof(billingoService));
            _discordService = discordService ?? throw new ArgumentException(nameof(discordService));

            _kreditPurchaseRepository = kreditPurchaseRepository ?? throw new ArgumentException(nameof(kreditPurchaseRepository));
            _payPalBillingAddressRepository = payPalBillingAddressRepository ?? throw new ArgumentException(nameof(payPalBillingAddressRepository));
            _payPalOrderRepository = payPalOrderRepository ?? throw new ArgumentException(nameof(payPalOrderRepository));
            _userRepository = userRepository ?? throw new ArgumentException(nameof(userRepository));

            _logger = logger ?? throw new ArgumentException(nameof(logger));
            _options = options ?? throw new ArgumentException(nameof(options));
        }

        public async Task<FinishedPayPalTransactionDTO> GetFinishedTransactionAsync(string orderId)
        {
            var order = await _payPalOrderRepository.GetFinisheByOrderIdAsync(orderId);

            if (order == null)
            {
                throw new NotFoundException();
            }

            return _payPalMapper.MapToFinishedTransactionDTO(order);
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
                var verificationRequest = WebRequest.Create(_options.Value.PayPalConfig.BaseUrl);
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
            _logger.LogInformation("PayPal IPN BODY: " + bodyJson);

            var payment = JsonConvert.DeserializeObject<PayPalCaptureDTO>(bodyJson, jsonSerializerSettings);
            if (payment == null)
            {
                throw new InvalidIPNBodyException();
            }

            var order = await _payPalOrderRepository.GetUnfinisheByOrderIdAsync(payment.PayPalResource.Id);
            if (order == null)
            {
                throw new InvalidIPNBodyException();
            }
            var user = await _userRepository.GetByIdAsync(order.UserId);
            if (user == null)
            {
                throw new InvalidIPNBodyException();
            }

            try
            {
                foreach (var purchaseUnit in payment.PayPalResource.PurchaseUnits)
                {
                    foreach (var capture in purchaseUnit.Payments.Captures)
                    {
                        await VerifySinglePaymentAsync(payment.PayPalResource.Id, capture);
                    }
                }

                await _kreditPurchaseRepository.AddAsync(new KreditPurchase()
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
                    PaymentType = "paypal",
                    CountryCode = order.PayPalBillingAddress.Country,
                    ZipCode = order.PayPalBillingAddress.Zip.ToString(),
                    City = order.PayPalBillingAddress.City,
                    Address = order.PayPalBillingAddress.Street,
                    Taxnumber = order.TaxNumber,
                    UserName = user.UserName,
                    Comment = "PayPal Id: " + order.OrderId
                });

                await _notificationService.CreateKreditPurchaseNotificationAsync(new KreditPurchaseNotification()
                {
                    KreditValue = order.KreditAmount,
                    PaymentType = "PayPal",
                    UserId = user.Id
                });

                await _discordService.SendMessageToStaffAsync(string.Format(
                    _options.Value.DiscordSettings.PurchaseMessage,
                    DateTime.Now.ToString("yyyy. MM. dd. HH:mm"),
                    user.UserName,
                    Convert.ToInt32(order.KreditAmount),
                    Convert.ToInt32(order.CurrencyValue),
                    "PayPal"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                _logger.LogError("PayPal Error: " + JsonConvert.SerializeObject(e));
                throw e;
            }
        }

        private async Task VerifySinglePaymentAsync(string orderId, PayPalPaymentCaptureDTO capture)
        {
            try
            {
                if (!capture.Status.Equals("COMPLETED", StringComparison.OrdinalIgnoreCase))
                {
                    _logger.LogInformation("PayPal PAYMENT: Not completed");
                    return;
                }

                var order = await _payPalOrderRepository.GetUnfinisheByOrderIdAsync(orderId);
                if (order == null)
                {
                    _logger.LogInformation("PayPal PAYMENT: Order in database not found: " + orderId);
                    return;
                }

                var user = await _userRepository.GetByIdAsync(order.UserId);
                if (user == null)
                {
                    _logger.LogInformation("PayPal PAYMENT: User not found");
                    return;
                }

                var requestedOrder = await RequestPayPalOrderByIdAsync(orderId);
                if (requestedOrder == null)
                {
                    _logger.LogInformation("PayPal PAYMENT: Order from paypal returned null: " + JsonSerializer.Serialize(capture));
                    return;
                }
                
                if (!requestedOrder.Status.Equals("COMPLETED", StringComparison.OrdinalIgnoreCase))
                {
                    _logger.LogInformation("PayPal PAYMENT: Order from paypal has not been completed: " + JsonSerializer.Serialize(requestedOrder));
                    return;
                }

                var splited = capture.Amount.Value.Split('.')[0];
                user.Currency += Convert.ToInt32(splited);
                await _userRepository.UpdateAsync(user);

                order.IsFinished = true;
                await _payPalOrderRepository.UpdateAsync(order);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                _logger.LogError("PayPal PAYMENT: " + e.Message);
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
                var verificationRequest = WebRequest.Create(_options.Value.PayPalConfig.BaseUrl + "/" + id);
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

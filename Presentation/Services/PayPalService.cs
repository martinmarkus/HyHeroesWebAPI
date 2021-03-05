using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mappers.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HyHeroesWebAPI.Infrastructure.Infrastructure.ConfigObjects;
using HyHeroesWebAPI.Presentation.DTOs.PayPalDTOs;
using HyHeroesWebAPI.Presentation.DTOs.PayPalOrderDTOs;
using Microsoft.Extensions.Options;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class PayPalService : IPayPalService
    {
        private readonly IPayPalTransactionRequestRepository _payPalTransactionRequestRepository;
        private readonly IPayPalOrderRepository _payPalOrderRepository;
        private readonly IPayPalLinkRepository _payPalLinkRepository;

        private readonly IPurchasedProductRepository _purchasedProductRepository;
        private readonly IUserRepository _userRepository;

        private readonly IPayPalMapper _payPalMapper;
        private ILogger<object> _logger;
        private IOptions<AppSettings> _appSettings;
        public PayPalService(
            IPayPalTransactionRequestRepository payPalTransactionRequestRepository,
            IPayPalOrderRepository payPalOrderRepository,
            IPayPalLinkRepository payPalLinkRepository,
            IPurchasedProductRepository purchasedProductRepository,
            IUserRepository userRepository,
            ILogger<object> logger,
            IPayPalMapper payPalMapper,
            IOptions<AppSettings> appSettings)
        {
            _payPalTransactionRequestRepository = payPalTransactionRequestRepository ?? throw new ArgumentException(nameof(payPalTransactionRequestRepository));
            _payPalOrderRepository = payPalOrderRepository ?? throw new ArgumentException(nameof(payPalOrderRepository));
            _payPalLinkRepository = payPalLinkRepository ?? throw new ArgumentException(nameof(payPalLinkRepository));
            _purchasedProductRepository = purchasedProductRepository ?? throw new ArgumentException(nameof(purchasedProductRepository));
            _userRepository = userRepository ?? throw new ArgumentException(nameof(userRepository));

            _payPalMapper = payPalMapper ?? throw new ArgumentException(nameof(payPalMapper));

            _logger = logger ?? throw new ArgumentException(nameof(logger));
            _appSettings = appSettings ?? throw new ArgumentException(nameof(appSettings));
        }

        public async Task<PayPalOrderResponseDTO> CreatePayPalTransactionAsync(string authenticatedUserName)
        {
            var user = await _userRepository.GetByUserNameAsync(authenticatedUserName);
            if (user == null)
            {
                throw new UnauthorizedAccessException();
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
                            value = "10.00"
                        },
                        description = "Valami teszt"
                    }
                }
            };

            PayPalOrder payPalOrder = null;
            try
            {
                var verificationRequest = WebRequest.Create("https://api-m.sandbox.paypal.com/v2/checkout/orders");
                verificationRequest.Method = "POST";
                verificationRequest.ContentType = "application/json";
                verificationRequest.Headers.Add(
                    "Authorization",
                    "Bearer A21AAK6MTN0qJTA1zPbz5SoFe0bKGOq6-LP0pJvMYbYTQ0Q6J9d07q7zJYWDPlr-759Uub9kjHhumUvwUsf677xFYdNEx_sJw");

                _logger.LogInformation("EDMONGDEBUG: JSON: " + JsonSerializer.Serialize(createdOrder));

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
                        payPalOrder = JsonConvert.DeserializeObject<PayPalOrder>(response);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        _logger.LogInformation("EDMONGDEBUG: ERROR OCCURED UNMAPPING: " + response);
                        throw new InvalidIPNBodyException();
                    }
                }

                payPalOrder.UserId = user.Id;
            }
            catch (Exception e)
            {
                _logger.LogInformation("EDMONGDEBUG: ERROR OCCURED VERIFYING: " + e.Message);
                throw new InvalidIPNBodyException();
            }

            var order = await _payPalOrderRepository.AddAsync(payPalOrder);
            return new PayPalOrderResponseDTO() 
            { 
                Id = order.OrderId
            };
        }

        public void TryVerifyPayment(string bodyJson)
        {
            PayPalCaptureDTO captureDto = null;

            try
            {
                var jsonSerializerSettings = new JsonSerializerSettings();
                jsonSerializerSettings.MissingMemberHandling = MissingMemberHandling.Ignore;
                captureDto = JsonConvert.DeserializeObject<PayPalCaptureDTO>(bodyJson, jsonSerializerSettings);
            }
            catch (Exception e)
            {
                _logger.LogInformation("EDMONGDEBUG: ERROR JSON PROCESS VERIFY : " + bodyJson);
                _logger.LogInformation("EDMONGDEBUG: ERROR JSON PROCESS VERIFY ERROR: " + e.Message);
                throw new InvalidIPNBodyException();
            }

            captureDto?.PayPalResource.PurchaseUnits.ForEach(payment =>
            {
                payment.Payments.Captures.ForEach(async capture =>
                {
                    if (capture.Status != "COMPLETED")
                    {
                        return;
                    }

                    var order = await _payPalOrderRepository.GetByOrderIdAsync(capture.Id);
                    if (order?.User == null)
                    {
                        return;
                    }

                    var user = order.User;
                    user.Currency += (int) Math.Round(double.Parse(capture.Amount.Value));
                });
            });
        }
    }
}

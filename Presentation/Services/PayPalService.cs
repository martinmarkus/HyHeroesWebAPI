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

namespace HyHeroesWebAPI.Presentation.Services
{
    public class PayPalService : IPayPalService
    {
        private readonly IPayPalTransactionRequestRepository _payPalTransactionRequestRepository;
        private readonly IPayPalOrderRepository _payPalOrderRepository;
        private readonly IPayPalTokenService _payPalTokenService;

        private readonly IPurchasedProductRepository _purchasedProductRepository;
        private readonly IUserRepository _userRepository;

        private ILogger<object> _logger;
        public PayPalService(
            IPayPalTransactionRequestRepository payPalTransactionRequestRepository,
            IPayPalOrderRepository payPalOrderRepository,
            IPayPalTokenService payPalTokenService,
            IPurchasedProductRepository purchasedProductRepository,
            IUserRepository userRepository,
            ILogger<object> logger)
        {
            _payPalTransactionRequestRepository = payPalTransactionRequestRepository ?? throw new ArgumentException(nameof(payPalTransactionRequestRepository));
            _payPalOrderRepository = payPalOrderRepository ?? throw new ArgumentException(nameof(payPalOrderRepository));
            _payPalTokenService = payPalTokenService ?? throw new ArgumentException(nameof(payPalTokenService));
            _purchasedProductRepository = purchasedProductRepository ?? throw new ArgumentException(nameof(purchasedProductRepository));
            _userRepository = userRepository ?? throw new ArgumentException(nameof(userRepository));

            _logger = logger ?? throw new ArgumentException(nameof(logger));
        }

        public async Task<PayPalOrderResponseDTO> CreatePayPalTransactionAsync(string authenticatedUserName)
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
                            value = "10000.00"
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

                payPalOrder.UserId = user.Id;
            }
            catch
            {
                throw new InvalidIPNBodyException();
            }

            var order = await _payPalOrderRepository.AddAsync(payPalOrder);
            await _payPalOrderRepository.SaveChangesAsync();

            return new PayPalOrderResponseDTO
            { 
                Id = order.OrderId
            };
        }

        public void TryVerifyPayments(string bodyJson)
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

                payment.PayPalResource.PurchaseUnits.ForEach(unit =>
                {
                    unit.Payments.Captures.ForEach(async capture =>
                    {
                        await TryVerifyOnePaymentAsync(payment.PayPalResource.Id, capture);
                    });
                });

            }
            catch
            {
                throw new InvalidIPNBodyException();
            }
        }

        private async Task TryVerifyOnePaymentAsync(string orderId, PayPalPaymentCaptureDTO capture)
        {
            try
            {
                if (capture.Status != "COMPLETED")
                {
                    _logger.LogInformation("PAYMENT: Not completed");
                    return;
                }

                var order = await _payPalOrderRepository.GetByOrderIdAsync(orderId);
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
                
                if (requestedOrder.Status != "COMPLETED")
                {
                    _logger.LogInformation("PAYMENT: Order from paypal has not been completed: " + JsonSerializer.Serialize(requestedOrder));
                    return;
                }

                user.Currency += (int)Math.Round(double.Parse(capture.Amount.Value));
                await _userRepository.SaveChangesAsync();

                await _payPalOrderRepository.RemoveAsync(order.Id);
                _logger.LogInformation("PAYMENT: Done");
            }
            catch (Exception e)
            {
                _logger.LogInformation("PAYMENT: ERROR: " + e.Message);
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
                _logger.LogInformation("PAYMENT: REQUEST PAYPAL ERROR: " + e.Message);
                return null;
            }

            return payPalOrder;
        }
    }
}

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
using System.Linq;
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

        public async Task<PayPalOrderResponseDTO> CreatePayPalTransaction(string authenticatedUserName)
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
                verificationRequest.Headers.Add("Authorization", "Bearer A21AAKo2lfllmTtzzBLTVbywtswVUHJoLp-IrW7zlQvF4WKL1mHkVlHOJt9oqoySZCf04ngKVYxXPq379CdIQbhCO_xomx16w");

                _logger.LogInformation("EDMONGDEBUG: JSON: " + JsonSerializer.Serialize(createdOrder));

                string strRequest = JsonSerializer.Serialize(createdOrder);
                verificationRequest.ContentLength = strRequest.Length;

                await using (StreamWriter writer = new StreamWriter(await verificationRequest.GetRequestStreamAsync(), Encoding.ASCII))
                {
                    await writer.WriteAsync(strRequest);
                }

                using (StreamReader reader = new StreamReader(verificationRequest.GetResponse().GetResponseStream()))
                {
                    var response = await reader.ReadToEndAsync();
                    try
                    {
                        payPalOrder = JsonConvert.DeserializeObject<PayPalOrder>(response);
                    }
                    catch (Exception e)
                    {
                        _logger.LogInformation("EDMONGDEBUG: ERROR OCCURED UNMAPPING: " + response);
                        throw new InvalidIPNBodyException();
                    }
                }

                payPalOrder.UserId = user.Id;
            }
            catch (Exception exception)
            {
                _logger.LogInformation("EDMONGDEBUG: ERROR OCCURED VERIFYING: " + exception.Message);
                throw new InvalidIPNBodyException();
            }

            var order = await _payPalOrderRepository.AddAsync(payPalOrder);

            var orderResponseDto = new PayPalOrderResponseDTO
            {
                Id = order.OrderId,
                PayPalStatus = order.Status,
                Links = new List<PayPalLinkDTO>()
            };

            order.PayPalLinks.ForEach(link =>
            {
                orderResponseDto.Links.Add(new PayPalLinkDTO
                {
                    Href = link.Href,
                    Method = link.Method,
                    Rel = link.Rel
                });
            });

            return orderResponseDto;
        }

        public async Task VerifyTask(PayPalIPNContextDTO ipnContext)
        {
            PayPalCaptureDTO payPalCapture = null;
            try
            {
                payPalCapture = JsonConvert.DeserializeObject<PayPalCaptureDTO>(ipnContext.RequestBody);
            }
            catch (Exception e)
            {
                _logger.LogInformation("EDMONDDEBUG: Failed to map request body to capture dto");
                throw new InvalidIPNBodyException();
            }
            try
            {
                var verificationRequest = WebRequest.Create("https://api-m.sandbox.paypal.com/v1/payments/authorization/9T287484DP554682S/capture");

                //Set values for the verification request
                verificationRequest.Method = "POST";
                verificationRequest.ContentType = "application/x-www-form-urlencoded";

                //Add cmd=_notify-validate to the payload
                string strRequest = "cmd=_notify-validate&" + ipnContext.RequestBody;
                verificationRequest.ContentLength = strRequest.Length;

                //Attach payload to the verification request
                using (StreamWriter writer = new StreamWriter(verificationRequest.GetRequestStream(), Encoding.ASCII))
                {
                    await writer.WriteAsync(strRequest);
                }

                //Send the request to PayPal and get the response
                using (StreamReader reader = new StreamReader(verificationRequest.GetResponse().GetResponseStream()))
                {
                    ipnContext.Verification = await reader.ReadToEndAsync();
                }
            }
            catch (Exception exception)
            {
                _logger.LogInformation("EDMONGDEBUG: ERROR OCCURED VERIFYING: " + exception.Message);
                //Capture exception for manual investigation
            }

            ProcessVerificationResponse(ipnContext);
        }

        private void ProcessVerificationResponse(PayPalIPNContextDTO ipnContext)
        {
            if (ipnContext.Verification.Equals("VERIFIED"))
            {
                _logger.LogInformation("EDMONGDEBUG: VERIFIED");
                // check that Payment_status=Completed
                // check that Txn_id has not been previously processed
                // check that Receiver_email is your Primary PayPal email
                // check that Payment_amount/Payment_currency are correct
                // process payment
            }
            else if (ipnContext.Verification.Equals("INVALID"))
            {
                _logger.LogInformation("EDMONGDEBUG: INVALID");
                _logger.LogInformation("EDMONGDEBUG PROCESS VER: " + JsonConvert.SerializeObject(ipnContext));
                //Log for manual investigation
            }
            else
            {
                _logger.LogInformation("EDMONGDEBUG: ERROR");
                //Log error
            }
        }

        public async Task<bool> ProcessIPNStreamAsync(Stream ipnStream)
        {
            if (ipnStream == null)
            {
                _logger.LogInformation("EDMONDDEBUG1: Invalid IPN Body");
                throw new InvalidIPNBodyException();
            }

            var rawIPNBody = string.Empty;
            try
            {
                _logger.LogInformation("EDMONDDEBUG1: Starting ipn body stream");
                using (var reader = new StreamReader(ipnStream, Encoding.UTF8))
                {
                    string line;
                    while ((line = await reader.ReadLineAsync()) != null)
                    {
                        _logger.LogInformation("EDMONDDEBUG1: Line: " + line);
                        rawIPNBody += line;
                    }
                }
            }
            catch (Exception e)
            {
                _logger.LogInformation("EDMONDDEBUG1: " + e.Message);
                throw new InvalidIPNBodyException();
            }

            var ipnMessage = _payPalMapper.MapToIPNMessage(rawIPNBody);
            _logger.LogInformation("EDMONDDEBUG1: " + JsonConvert.SerializeObject(ipnMessage));

            var isIPNValid =  await IsIPNValidAsync(ipnMessage);
            _logger.LogInformation("EDMONDDEBUG2: " + JsonConvert.SerializeObject(isIPNValid));

            if (isIPNValid)
            {
                //var addedIPNMessage = await _payPalIPNMessageRepository.AddAsync(ipnMessage);

                // TODO: kredit hozzáadása
            }

            _logger.LogInformation("EDMONDDEBUG1: Done ipn process");
            return true;
        }

        private async Task<bool> IsIPNValidAsync(PayPalIPNMessage ipnMessage)
        {
            // INFO: Custom Transcation Id check:
            var isGuid = Guid.TryParse(ipnMessage.Custom, out Guid transactionId);
            if (!isGuid)
            {
                throw new InvalidIPNBodyException();
            }
            
            var payPalTransaction = await _payPalTransactionRequestRepository.GetByIdAsync(transactionId);
            
            if (payPalTransaction == null 
                || transactionId != payPalTransaction.Id 
                || payPalTransaction.IsRequestProcessed)
                //|| payPalTransaction.TimeStamp.AddMinutes(60) < DateTime.Now)
            {
                throw new InvalidIPNBodyException();
            }

            // INFO at this point the custom id is valid




            // TODO: implement
            return true;
        }
    }
}

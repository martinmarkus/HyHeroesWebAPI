using HyHeroesWebAPI.ApplicationCore.DataObjects;
using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.ApplicationCore.Enums;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Presentation.ConfigObjects;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using HyHeroesWebAPI.Presentation.Utils;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class EDSMSService : IEDSMSService
    {
        private readonly IEDSMSPurchaseRepository _EDSMSPurchaseRepository;
        private readonly IUserRepository _userRepository;
        private readonly IKreditPurchaseRepository _kreditPurchaseRepository;
        private readonly IJatekfizetesRequestRepository _jatekfizetesRequestRepository;

        private readonly INotificationService _notificationService;
        private readonly IHttpRequestService _httpRequestService;

        private readonly FormatterUtil _formatterUtil;
        private readonly IOptions<AppSettings> _appSettings;

        public EDSMSService(
            IEDSMSPurchaseRepository EDSMSPurchaseRepository,
            IUserRepository userRepository,
            IKreditPurchaseRepository kreditPurchaseRepository,
            IJatekfizetesRequestRepository jatekfizetesRequestRepository,
            IOptions<AppSettings> appSettings,
            IHttpRequestService httpRequestService,
            INotificationService notificationService,
            FormatterUtil formatterUtil)
        {
            _EDSMSPurchaseRepository = EDSMSPurchaseRepository ?? throw new ArgumentException(nameof(EDSMSPurchaseRepository));
            _userRepository = userRepository ?? throw new ArgumentException(nameof(userRepository));
            _kreditPurchaseRepository = kreditPurchaseRepository ?? throw new ArgumentException(nameof(kreditPurchaseRepository));
            _jatekfizetesRequestRepository = jatekfizetesRequestRepository ?? throw new ArgumentException(nameof(jatekfizetesRequestRepository));

            _httpRequestService = httpRequestService ?? throw new ArgumentException(nameof(httpRequestService));
            _notificationService = notificationService ?? throw new ArgumentException(nameof(notificationService));

            _formatterUtil = formatterUtil ?? throw new ArgumentException(nameof(formatterUtil));
            _appSettings = appSettings ?? throw new ArgumentException(nameof(appSettings));
        }

        public async Task<AppliedEDSMSKreditDTO> ApplyJatekFizetesCallAsync(
            ApplyKreditDTO applyKreditDTO,
            string clientIP)
        {
            var user = await _userRepository.GetByUserNameAsync(applyKreditDTO.UserName);
            if (user == null)
            {
                throw new NotFoundException();
            }

            var isOnCooldown = await _jatekfizetesRequestRepository.IsClientIPOnCooldownAsync(clientIP);
            if (isOnCooldown)
            {
                throw new JatekfizetesCooldownException();
            }

            var response = await SendJatekFizetesCallAsync(applyKreditDTO.ActivationCode);

            var responseArray = response.Split(@";");
            var responseCode = responseArray[0].ToString();

            if (responseArray.Length != 2 || 
                (!responseCode.Equals("07", StringComparison.Ordinal)
                && !responseCode.Equals("33", StringComparison.Ordinal)))
            {
                await _jatekfizetesRequestRepository.AddAsync(new JatekfizetesRequest()
                {
                    CallDate = DateTime.Now,
                    CallerUserId = user.Id,
                    ClientIP = clientIP,
                    IsActivationSuccessful = false
                });

                if (responseCode.Equals("09", StringComparison.Ordinal)
                    || responseCode.Equals("10", StringComparison.Ordinal)
                    || responseCode.Equals("11", StringComparison.Ordinal))
                {
                    throw new EDSMSCooldownException();
                }
                else if (responseCode.Equals("03", StringComparison.Ordinal)
                    || responseCode.Equals("04", StringComparison.Ordinal))
                {
                    throw new SMSCodeAlreadyUsedException();
                }
                else
                {
                    throw new SMSException();
                }
            }

            var grossSpent = responseArray[1]?.ToString();
            if (string.IsNullOrEmpty(grossSpent))
            {
                throw new InvalidKreditAmountException();
            }

            return await ApplyValidatedEDSMSCodeAsync(
                Convert.ToInt32(grossSpent),
                user,
                applyKreditDTO,
                clientIP);
        }

        private async Task<AppliedEDSMSKreditDTO> ApplyValidatedEDSMSCodeAsync(
            int grossSpent,
            User user,
            ApplyKreditDTO applyKreditDTO,
            string clientIP)
        {
            var purchasedKreditAmount = 0;
            foreach (var type in _appSettings.Value.EDSMSPurchaseTypes)
            {
                if (type.GrossPrice == grossSpent)
                {
                    purchasedKreditAmount = type.KreditValue;
                    break;
                }
            }

            if (purchasedKreditAmount <= 0)
            {
                throw new InvalidKreditAmountException();
            }

            user.Currency += purchasedKreditAmount;
            await _userRepository.UpdateAsync(user);

            var addedKreditPurchase = await _kreditPurchaseRepository.AddAsync(new KreditPurchase() 
            {
                KreditValue = purchasedKreditAmount,
                CurrencyValue = grossSpent,
                PaymentType = PaymentType.EDSMS,
                UserId = user.Id
            });

            await _EDSMSPurchaseRepository.AddAsync(new EDSMSPurchase()
            {
                ActivationCode = applyKreditDTO.ActivationCode,
                KreditPurchaseId = addedKreditPurchase.Id
            });

            await _jatekfizetesRequestRepository.AddAsync(new JatekfizetesRequest()
            {
                CallDate = DateTime.Now,
                CallerUserId = user.Id,
                ClientIP = clientIP,
                IsActivationSuccessful = true
            });

            await _notificationService.CreateKreditPurchaseNotificationAsync(new KreditPurchaseNotification()
            {
                KreditValue = purchasedKreditAmount,
                PaymentType = "EDSMS",
                UserId = user.Id
            });

            return new AppliedEDSMSKreditDTO()
            {
                KreditValue = purchasedKreditAmount
            };
        }

        private async Task<string> SendJatekFizetesCallAsync(string smsCode)
        {
            var callRoute = _appSettings.Value.JatekFizetesOptions.APIRoute
                + "?api_key=" + _appSettings.Value.JatekFizetesOptions.APIKey
                + "&sms_kod=" + smsCode
                + "&url=" + _appSettings.Value.JatekFizetesOptions.ThirdPartyIPResponse;

            var rawResponse = await _httpRequestService.GetJsonResponseAsync(new HttpRequestData()
            {
                Url = callRoute,
                Method = "GET"
            });

            return _formatterUtil.StripHTMLTags(rawResponse.JsonContent);
        }

        public IList<EDSMSPurchaseTypeDTO> GetEDSMSPurchaseTypes()
        {
            var dto = new List<EDSMSPurchaseTypeDTO>();

            foreach (var type in _appSettings.Value.EDSMSPurchaseTypes)
            {
                dto.Add(new EDSMSPurchaseTypeDTO()
                {
                    GrossPrice = type.GrossPrice,
                    KreditValue = type.KreditValue
                });
            }

            return dto;
        }
    }
}

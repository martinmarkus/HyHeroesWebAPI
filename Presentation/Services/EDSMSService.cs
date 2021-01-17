using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.ApplicationCore.Enums;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Infrastructure.Utils;
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
        private readonly IEDSMSActivationCodeRepository _EDSMSActivationCodeRepository;

        private readonly IOptions<AppSettings> _appSettings;
        private readonly RandomStringGenerator<EDSMSActivationCode> _randomStringGenerator;
        public EDSMSService(
            IEDSMSPurchaseRepository EDSMSPurchaseRepository,
            IUserRepository userRepository,
            IKreditPurchaseRepository kreditPurchaseRepository,
            IEDSMSActivationCodeRepository EDSMSActivationCodeRepository,
            IOptions<AppSettings> appSettings,
            RandomStringGenerator<EDSMSActivationCode> randomStringGenerator)
        {
            _EDSMSPurchaseRepository = EDSMSPurchaseRepository ?? throw new ArgumentException(nameof(EDSMSPurchaseRepository));
            _userRepository = userRepository ?? throw new ArgumentException(nameof(userRepository));
            _kreditPurchaseRepository = kreditPurchaseRepository ?? throw new ArgumentException(nameof(kreditPurchaseRepository));
            _EDSMSActivationCodeRepository = EDSMSActivationCodeRepository ?? throw new ArgumentException(nameof(EDSMSActivationCodeRepository));
            _appSettings = appSettings ?? throw new ArgumentException(nameof(appSettings));
            _randomStringGenerator = randomStringGenerator ?? throw new ArgumentException(nameof(randomStringGenerator));
        }

        public async Task<EDSMSActivationCode> ProcessEDSMSAsync(EDSMSPurchase EDSMSPurchase)
        {
            await _EDSMSPurchaseRepository.AddAsync(EDSMSPurchase);

            var EDSMSTypes = GetEDSMSPurchaseTypes();
            var selectedType = default(EDSMSPurchaseTypeDTO);

            foreach(var type in EDSMSTypes)
            {
                if (Int32.Parse(EDSMSPurchase.GrossPrice) == type.GrossPrice)
                {
                    selectedType = type;
                    break;
                }
            }

            if (selectedType == null)
            {
                throw new EDSMSGrossPriceNotFoundException(EDSMSPurchase.GrossPrice);
            }

            var createdKreditPurchase = await _kreditPurchaseRepository.AddAsync(new KreditPurchase()
            {
                KreditValue = selectedType.KreditValue,
                CurrencyValue = Convert.ToInt32(selectedType.GrossPrice),
                PaymentType = PaymentType.EDSMS
            });

            var unusedCodes = await _EDSMSActivationCodeRepository.GetAllUnusedCodesAsync();

            var addedCode = await _EDSMSActivationCodeRepository.AddAsync(new EDSMSActivationCode()
            {
                Code = _randomStringGenerator.GetRandomString(unusedCodes),
                SenderPhoneNumber = selectedType.PhoneNumber,
                KreditValue = selectedType.KreditValue,
                IsUsed = false,
                KreditPurchaseId = createdKreditPurchase.Id,
                KreditPurchase = createdKreditPurchase,
                IsGeneratedByAdmin = false
            });

            return addedCode;
        }

        public async Task<AppliedEDSMSKreditDTO> ApplyKreditAsync(ApplyKreditDTO applyKreditDTO)
        {
            var activationCode = await _EDSMSActivationCodeRepository
                .GetUnusedCodeByCodeValueAsync(applyKreditDTO.ActivationCode);
            if (activationCode == null)
            {
                throw new NotFoundException();
            }

            var user = await _userRepository.GetByUserNameAsync(applyKreditDTO.UserName);
            if (user == null)
            {
                throw new NotFoundException();
            }

            user.Currency += activationCode.KreditValue;
            await _userRepository.UpdateAsync(user);

            activationCode.IsUsed = true;
            await _EDSMSActivationCodeRepository.UpdateAsync(activationCode);

            return new AppliedEDSMSKreditDTO()
            {
                KreditValue = activationCode.KreditValue
            };
        }

        public IList<EDSMSPurchaseTypeDTO> GetEDSMSPurchaseTypes() =>
            _appSettings.Value.EDSMSPurchaseTypes;

        public async Task<List<EDSMSActivationCode>> GenerateActivationCodesAsync(
            int codeAmount,
            int kreditValue)
        {
            if (codeAmount <= 0 || kreditValue <= 0)
            {
                return null;
            }

            var codes = new List<EDSMSActivationCode>();
            for (int i = 0; i < codeAmount; i++)
            {
                var unusedCodes = await _EDSMSActivationCodeRepository.GetAllUnusedCodesAsync();

                codes.Add(new EDSMSActivationCode()
                {
                    Code = _randomStringGenerator.GetRandomString(unusedCodes),
                    KreditValue = kreditValue,
                    IsUsed = false,
                    IsGeneratedByAdmin = true
                });
            }

            await _EDSMSActivationCodeRepository.AddRangeAsync(codes);

            return codes;
        }
    }
}

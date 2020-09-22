using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.ApplicationCore.Enums;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Presentation.ConfigObjects;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.Extensions.Options;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class EDSMSService : IEDSMSService
    {
        private readonly IEDSMSPurchaseRepository _EDSMSPurchaseRepository;
        private readonly IUserRepository _userRepository;
        private readonly IPurchasedProductRepository _purchasedProductRepository;
        private readonly IKreditPurchaseRepository _kreditPurchaseRepository;

        private readonly IOptions<AppSettings> _appSettings;

        public EDSMSService(
            IEDSMSPurchaseRepository EDSMSPurchaseRepository,
            IUserRepository userRepository,
            IPurchasedProductRepository purchasedProductRepository,
            IKreditPurchaseRepository kreditPurchaseRepository, 
            IOptions<AppSettings> appSettings)
        {
            _EDSMSPurchaseRepository = EDSMSPurchaseRepository ?? throw new ArgumentException(nameof(EDSMSPurchaseRepository));
            _userRepository = userRepository ?? throw new ArgumentException(nameof(userRepository));
            _kreditPurchaseRepository = kreditPurchaseRepository ?? throw new ArgumentException(nameof(kreditPurchaseRepository));
            _purchasedProductRepository = purchasedProductRepository ?? throw new ArgumentException(nameof(purchasedProductRepository));
            _appSettings = appSettings ?? throw new ArgumentException(nameof(appSettings));
        }

        public Task<bool> ExecutePayment(PaymentTransactionDTO paymentTransactionDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ProcessEDSMSAsync(EDSMSPurchase EDSMSPurchase)
        {
            var addedPurchase = await _EDSMSPurchaseRepository.AddAsync(EDSMSPurchase);

            var user = await _userRepository.GetByUserNameAsync(EDSMSPurchase.UserName);
            if (user == null)
            {
                throw new NotFoundException();
            }

            var EDSMSTypes = GetEDSMSPurchaseTypes();
            EDSMSPurchaseTypeDTO selectedType = null;
            foreach(var type in EDSMSTypes)
            {
                if (EDSMSPurchase.GrossPrice.Equals(type.GrossPrice))
                {
                    selectedType = type;
                    user.Currency += type.KreditValue;
                    break;
                }
            }

            await _kreditPurchaseRepository.AddAsync(new KreditPurchase()
            {
                KreditValue = selectedType.KreditValue,
                CurrencyValue = Convert.ToInt32(selectedType.GrossPrice),
                CreationDate = DateTime.Now,
                User = user,
                UserId = user.Id,
                PaymentType = PaymentType.EDSMS
            });

            await _userRepository.UpdateAsync(user);

            return true;
        }

        public IList<EDSMSPurchaseTypeDTO> GetEDSMSPurchaseTypes() =>
            _appSettings.Value.EDSMSPurchaseTypes;
    }
}

using HyHeroesWebAPI.Presentation.DTOs.WebsiteDTOs;
using HyHeroesWebAPI.Presentation.Mappers.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class KreditUploadService : IKreditUploadService
    {
        private readonly IUserService _userService;
        private readonly IBarionPaymentService _barionPaymentService;
        private readonly IEDSMSService  _EDSMSService;
        private readonly IBankTransferService _bankTransferService;
        private readonly IPayPalService _payPalService;
        private readonly IZipReaderService _zipReaderService;

        private readonly IUserMapper _userMapper;

        public KreditUploadService(
            IUserService userService,
            IBarionPaymentService barionPaymentService,
            IEDSMSService EDSMSService,
            IBankTransferService bankTransferService,
            IZipReaderService zipReaderService,
            IPayPalService payPalService,
            IUserMapper userMapper)
        {
            _userService = userService ?? throw new ArgumentException(nameof(userService));
            _barionPaymentService = barionPaymentService ?? throw new ArgumentException(nameof(barionPaymentService));
            _EDSMSService = EDSMSService ?? throw new ArgumentException(nameof(EDSMSService));
            _bankTransferService = bankTransferService ?? throw new ArgumentException(nameof(bankTransferService));
            _payPalService = payPalService ?? throw new ArgumentException(nameof(payPalService));

            _zipReaderService = zipReaderService ?? throw new ArgumentException(nameof(zipReaderService));
            _userMapper = userMapper ?? throw new ArgumentException(nameof(userMapper));
        }

        public async Task<KreditUploadDTO> GetKreditUploadDataAsync(string userName)
        {
            var user = await _userService.GetByUserNameAsync(userName);

            var EDSMSTypes = _EDSMSService.GetEDSMSPurchaseTypes();
            var barionPurchaseTypes = _barionPaymentService.GetBarionPurchaseTypes();
            var bankTransferPurchaseTypes = _bankTransferService.GetBankTransferPurchaseTypes();
            var payPalPurchaseTypes = _payPalService.GetPayPalPurchaseTypes();
            var countries = _userService.GetAcceptedBillingCountries();
            var zips = _zipReaderService.GetZipData();
            return new KreditUploadDTO()
            {
                User = _userMapper.MapToAuthenticatedUserDTO(user),
                AcceptedCountryList = countries,
                BarionPurchaseTypeList = barionPurchaseTypes,
                BankTransferTypeList = bankTransferPurchaseTypes,
                EDSMSTypeList = EDSMSTypes,
                PayPalPurchaseTypeList = payPalPurchaseTypes,
                Zips = zips
            };
        }
    }
}

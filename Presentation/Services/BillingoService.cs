using HyHeroesWebAPI.ApplicationCore.DataObjects;
using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Presentation.ConfigObjects;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mappers.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class BillingoService : IBillingoService
    {
        private readonly IBillingoBankAccountRepository _billingoBankAccountRepository;
        private readonly IBillingoDocumentRepository _billingoDocumentRepository;
        private readonly IBillingoDocumentSettingsRepository _billingoDocumentSettingsRepository;
        private readonly IBillingoBillingAddressRepository _billingoBillingAddressRepository;
        private readonly IBillingoPartnerRepository _billingoPartnerRepository;
        private readonly IBillingoProductRepository _billingoProductRepository;
        private readonly IUserRepository _userRepository;
        private readonly IBillingTransactionRepository _billingTransactionRepository;

        private readonly IBillingoMapper _billingoMapper;
        private readonly IBillingMapper _billingMapper;

        private readonly IOptions<AppSettings> _options;

        private readonly IHttpRequestService _httpRequestService;

        public BillingoService(
            IBillingoBankAccountRepository billingoBankAccountRepository,
            IBillingoDocumentRepository billingoDocumentRepository,
            IBillingoDocumentSettingsRepository billingoDocumentSettingsRepository, 
            IBillingoBillingAddressRepository billingoBillingAddressRepository,
            IBillingoPartnerRepository billingoPartnerRepository,
            IBillingoProductRepository billingoProductRepository,
            IUserRepository userRepository,
            IBillingTransactionRepository billingTransactionRepository,
            IBillingoMapper billingoMapper,
            IBillingMapper billingMapper,
            IOptions<AppSettings> options,
            IHttpRequestService httpRequestService)
        {
            _billingoBankAccountRepository = billingoBankAccountRepository ?? throw new ArgumentException(nameof(billingoBankAccountRepository));
            _billingoDocumentRepository = billingoDocumentRepository ?? throw new ArgumentException(nameof(billingoDocumentRepository));
            _billingoDocumentSettingsRepository = billingoDocumentSettingsRepository ?? throw new ArgumentException(nameof(billingoDocumentSettingsRepository));
            _billingoBillingAddressRepository = billingoBillingAddressRepository ?? throw new ArgumentException(nameof(billingoBillingAddressRepository));
            _billingoPartnerRepository = billingoPartnerRepository ?? throw new ArgumentException(nameof(billingoPartnerRepository));
            _billingoProductRepository = billingoProductRepository ?? throw new ArgumentException(nameof(billingoProductRepository));
            _userRepository = userRepository ?? throw new ArgumentException(nameof(userRepository));
            _billingTransactionRepository = billingTransactionRepository ?? throw new ArgumentException(nameof(billingTransactionRepository));

            _billingoMapper = billingoMapper ?? throw new ArgumentException(nameof(billingoMapper));
            _billingMapper = billingMapper ?? throw new ArgumentException(nameof(billingMapper));

            _options = options ?? throw new ArgumentException(nameof(options));

            _httpRequestService = httpRequestService ?? throw new ArgumentException(nameof(httpRequestService));
        }

        public async Task CreateBillAsync(KreditPurchaseTransactionDTO dto)
        {
            var user = await _userRepository.GetByUserNameAsync(dto.UserName);
            if (user == null)
            {
                throw new NotFoundException();
            }

            var partner = await GetUpdatedBillingoPartnerAsync(dto, user.Id);
            var bankAccount = await GetUpdatedBillingoBankAccountAsync();
            var settings = await GetUpdatedBillingoDocumentSettingsAsync();
            var document = await GetUpdatedBillingoDocumentAsync(dto, settings, partner, bankAccount);
            var product = await CreateKreditPurchaseAsBillingoProductAsync(dto, document.Id);

            // TODO: order: partner, account, document

            // INFO: logging the bill
            var billingTransaction = _billingMapper.MapToBillingTransaction(dto, user.Email);
            await _billingTransactionRepository.AddAsync(billingTransaction);

        }

        private async Task<BillingoPartner> GetUpdatedBillingoPartnerAsync(
            KreditPurchaseTransactionDTO dto,
            Guid userId)
        {
            var billingoPartner = await _billingoPartnerRepository.GetByUserIdAsync(userId);
            if (billingoPartner == null)
            {
                var newAddress = await _billingoBillingAddressRepository.AddAsync(new BillingoBillingAddress()
                {
                    CountryCode = dto.VevoOrszagkod,
                    City = dto.VevoTelepules,
                    PostCode = dto.VevoIrsz,
                    Address = dto.VevoCim,
                });

                billingoPartner = await _billingoPartnerRepository.AddAsync(new BillingoPartner()
                {
                    Emails = new string[] { dto.VevoEmail },
                    PartnerName = dto.VevoNev,
                    Taxcode = dto.VevoAdoszam,
                    UserId = userId,
                    BillingoBillingAddressId = newAddress.Id
                });
            }
            else
            {
                billingoPartner.BillingoBillingAddress.CountryCode = dto.VevoOrszagkod;
                billingoPartner.BillingoBillingAddress.City = dto.VevoTelepules;
                billingoPartner.BillingoBillingAddress.PostCode = dto.VevoIrsz;
                billingoPartner.BillingoBillingAddress.Address = dto.VevoCim;
                await _billingoBillingAddressRepository.UpdateAsync(billingoPartner.BillingoBillingAddress);

                billingoPartner.Emails = new string[] { dto.VevoEmail };
                billingoPartner.PartnerName = dto.VevoNev;
                billingoPartner.Taxcode = dto.VevoAdoszam;
                await _billingoPartnerRepository.UpdateAsync(billingoPartner);
            }

            return billingoPartner;
        }

        private async Task<BillingoBankAccount> GetUpdatedBillingoBankAccountAsync()
        {
            var bankAccount = await _billingoBankAccountRepository.GetSellerBankAccountAsync();

            if (bankAccount == null)
            {
                bankAccount = await _billingoBankAccountRepository.AddAsync(new BillingoBankAccount()
                {
                    AccountNumber = _options.Value.BillingoBillingSettings.BillingoBankAccount.AccountNumber,
                    AccountNumberIban = _options.Value.BillingoBillingSettings.BillingoBankAccount.AccountNumberIban,
                    Currency = _options.Value.BillingoBillingSettings.BillingoBankAccount.Currency,
                    Name = _options.Value.BillingoBillingSettings.BillingoBankAccount.Name,
                    NeeedQr = _options.Value.BillingoBillingSettings.BillingoBankAccount.NeeedQr,
                    Swift = _options.Value.BillingoBillingSettings.BillingoBankAccount.Swift
                });
            }

            return bankAccount;
        }

        private async Task<BillingoProduct> CreateKreditPurchaseAsBillingoProductAsync(
            KreditPurchaseTransactionDTO dto,
            Guid documentId) =>
            await _billingoProductRepository.AddAsync(new BillingoProduct()
            {
                BillingoDocumentId = documentId,
                Currency = _options.Value.BillingoBillingSettings.Currency,
                Entitlement = _options.Value.BillingoBillingSettings.Entitlement,
                NetUnitPrice = dto.CurrencyValue,
                ProductName = dto.KreditValue + " Kredit",
                Unit = _options.Value.BillingoBillingSettings.Unit,
                Vat = _options.Value.BillingoBillingSettings.Vat,
                Quantity = 1
            });

        private async Task<BillingoDocument> GetUpdatedBillingoDocumentAsync(
            KreditPurchaseTransactionDTO dto,
            BillingoDocumentSettings settings,
            BillingoPartner partner,
            BillingoBankAccount bankAccount) =>
            await _billingoDocumentRepository.AddAsync(new BillingoDocument()
            {
                BillingoBankAccountId = bankAccount.Id,
                BillingoDocumentSettingsId = settings.Id,
                CreationDate = DateTime.Now,
                DueDate = DateTime.Now,
                FulfillmentDate = DateTime.Now,
                PaymentType = dto.PaymentType,
                BankAccountId = Convert.ToInt64(bankAccount.BillingoBankAccountId),
                PartnerId = Convert.ToInt64(partner.BillingoPartnerId),
                Paid = true,
                Electronic = true
            });

        private async Task<BillingoDocumentSettings> GetUpdatedBillingoDocumentSettingsAsync()
        {
            var newId = Guid.NewGuid();
            return await _billingoDocumentSettingsRepository.AddAsync(new BillingoDocumentSettings()
            {
                Id = newId,
                MediatedService = false,
                WithoutFinancialFulfillment = false,
                OnlinePayment = string.Empty,
                Round = "five",
                OrderNumber = newId.ToString(),
                PlaceId = 0
            });
        }

        private async Task<T> SendBillingoCallAsync<T>(string method, object content)
        {
            var jsonContent = JsonConvert.SerializeObject(content);

            var response = await _httpRequestService.GetJsonResponseAsync(new HttpRequestData()
            {
                Url = _options.Value.BillingoBillingSettings.BillingoApiRoute,
                Method = method,
                JsonContent = jsonContent
            });

            return JsonConvert.DeserializeObject<T>(response.JsonContent);
        }
    }
}

using HyHeroesWebAPI.ApplicationCore.DataObjects;
using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.ApplicationCore.Enums;
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
using System.Collections.Generic;
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
        private readonly IUserRepository _userRepository;
        private readonly IBillingTransactionRepository _billingTransactionRepository;

        private readonly IBillingMapper _billingMapper;

        private readonly IOptions<AppSettings> _options;

        private readonly IHttpRequestService _httpRequestService;

        public BillingoService(
            IBillingoBankAccountRepository billingoBankAccountRepository,
            IBillingoDocumentRepository billingoDocumentRepository,
            IBillingoDocumentSettingsRepository billingoDocumentSettingsRepository, 
            IBillingoBillingAddressRepository billingoBillingAddressRepository,
            IBillingoPartnerRepository billingoPartnerRepository,
            IUserRepository userRepository,
            IBillingTransactionRepository billingTransactionRepository,
            IBillingMapper billingMapper,
            IOptions<AppSettings> options,
            IHttpRequestService httpRequestService)
        {
            _billingoBankAccountRepository = billingoBankAccountRepository ?? throw new ArgumentException(nameof(billingoBankAccountRepository));
            _billingoDocumentRepository = billingoDocumentRepository ?? throw new ArgumentException(nameof(billingoDocumentRepository));
            _billingoDocumentSettingsRepository = billingoDocumentSettingsRepository ?? throw new ArgumentException(nameof(billingoDocumentSettingsRepository));
            _billingoBillingAddressRepository = billingoBillingAddressRepository ?? throw new ArgumentException(nameof(billingoBillingAddressRepository));
            _billingoPartnerRepository = billingoPartnerRepository ?? throw new ArgumentException(nameof(billingoPartnerRepository));
            _userRepository = userRepository ?? throw new ArgumentException(nameof(userRepository));
            _billingTransactionRepository = billingTransactionRepository ?? throw new ArgumentException(nameof(billingTransactionRepository));

            _billingMapper = billingMapper ?? throw new ArgumentException(nameof(billingMapper));

            _options = options ?? throw new ArgumentException(nameof(options));

            _httpRequestService = httpRequestService ?? throw new ArgumentException(nameof(httpRequestService));
        }

        public async Task CreateBillAsync(CreateBillingoBillDTO dto)
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

            if (partner != null && !string.IsNullOrEmpty(partner.BillingoPartnerId))
            {
                var partnerDTO = _billingMapper.MapToPartnerDTO(partner);
                await SendBillingoCallAsync<BillingoPartnerDTO>(
                    "/partners/" + partnerDTO.BillingoPartnerId,
                    "PUT",
                    partnerDTO);
            }
            else
            {
                var partnerDTO = _billingMapper.MapToPartnerDTO(partner);
                partnerDTO = await SendBillingoCallAsync<BillingoPartnerDTO>(
                    "/partners",
                    "POST",
                    partnerDTO);
                partner.BillingoPartnerId = partnerDTO.BillingoPartnerId;
                await _billingoPartnerRepository.UpdateAsync(partner);
            }

            if (bankAccount == null || string.IsNullOrEmpty(bankAccount.BillingoBankAccountId))
            {
                var bankAccountResponse = await SendBillingoCallAsync<BillingoBankAccount>(
                    "/bank-accounts",
                    "POST",
                    bankAccount);
                bankAccount.BillingoBankAccountId = bankAccountResponse.BillingoBankAccountId;
                await _billingoBankAccountRepository.UpdateAsync(bankAccount);
            }

            var product = new BillingoProduct()
            {
                Comment = _options.Value.BillingoBillingSettings.BillableProductComment,
                Currency = _options.Value.BillingoBillingSettings.Currency,
                Entitlement = _options.Value.BillingoBillingSettings.Entitlement,
                UnitPrice = dto.CurrencyValue,
                UnitPriceType = _options.Value.BillingoBillingSettings.UnitPriceType,
                ProductName = dto.KreditValue + " Kredit",
                Quantity = 1,
                Unit = _options.Value.BillingoBillingSettings.Unit,
                Vat = _options.Value.BillingoBillingSettings.Vat
            };

            document.BillingoProducts = new BillingoProduct[] { product };
            document.BankAccountId = Convert.ToInt64(bankAccount.BillingoBankAccountId);
            document.PartnerId = Convert.ToInt64(partner.BillingoPartnerId);
           
            var documentResponse = await SendBillingoCallAsync<BillingoDocument>(
                   "/documents",
                   "POST",
                   document);

            document.BillingoDocumentId = documentResponse.BillingoDocumentId;
            await _billingoDocumentRepository.UpdateAsync(document);

            // INFO: logging the bill
            var billingTransaction = _billingMapper.MapToBillingTransaction(dto, user.Email);
            await _billingTransactionRepository.AddAsync(billingTransaction);


            await SendBillingoCallAsync<BillingoDocument>(
                "/documents/" + document.BillingoDocumentId + "/send",
                "POST");

        }

        private async Task<T> SendBillingoCallAsync<T>(
            string endpoint, 
            string method,
            object content = null)
             where T : new()
        {
            var jsonContent = JsonConvert.SerializeObject(
                content,
                Formatting.None,
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                });

            var headerValues = new Dictionary<string, string>();
            headerValues.Add("X-API-KEY", _options.Value.BillingoBillingSettings.BillingoApiKey);

            var response = await _httpRequestService.GetJsonResponseAsync(new HttpRequestData()
            {
                Url = _options.Value.BillingoBillingSettings.BillingoApiRoute + endpoint,
                Method = method,
                JsonContent = method.Equals("GET") ? null : jsonContent,
                HeaderValues = headerValues
            });

            return JsonConvert.DeserializeObject<T>(response.JsonContent);
        }

        private async Task<BillingoPartner> GetUpdatedBillingoPartnerAsync(
            CreateBillingoBillDTO dto,
            Guid userId)
        {
            var billingoPartner = await _billingoPartnerRepository.GetByUserIdAsync(userId);
            if (billingoPartner == null)
            {
                var newAddress = await _billingoBillingAddressRepository.AddAsync(new BillingoBillingAddress()
                {
                    CountryCode = dto.CountryCode,
                    City = dto.City,
                    PostCode = dto.ZipCode,
                    Address = dto.Address,
                });

                billingoPartner = await _billingoPartnerRepository.AddAsync(new BillingoPartner()
                {
                    Email = dto.ClientEmail,
                    PartnerName = dto.ClientName,
                    Taxcode = dto.Taxnumber,
                    UserId = userId,
                    BillingoBillingAddressId = newAddress.Id
                });
            }
            else
            {
                billingoPartner.BillingoBillingAddress.CountryCode = dto.CountryCode;
                billingoPartner.BillingoBillingAddress.City = dto.City;
                billingoPartner.BillingoBillingAddress.PostCode = dto.ZipCode;
                billingoPartner.BillingoBillingAddress.Address = dto.Address;
                await _billingoBillingAddressRepository.UpdateAsync(billingoPartner.BillingoBillingAddress);

                billingoPartner.Email =  dto.ClientEmail;
                billingoPartner.PartnerName = dto.ClientName;
                billingoPartner.Taxcode = dto.Taxnumber;
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
                    BankName = _options.Value.BillingoBillingSettings.BillingoBankAccount.BankName,
                    NeeedQr = _options.Value.BillingoBillingSettings.BillingoBankAccount.NeeedQr,
                });
            }

            return bankAccount;
        }

        private async Task<BillingoDocument> GetUpdatedBillingoDocumentAsync(
            CreateBillingoBillDTO dto,
            BillingoDocumentSettings settings,
            BillingoPartner partner,
            BillingoBankAccount bankAccount) =>
            await _billingoDocumentRepository.AddAsync(new BillingoDocument()
            {
                BillingoBankAccountId = bankAccount.Id,
                BillingoDocumentSettingsId = settings.Id,
                DueDate = DateTime.Now.ToString("yyyy-MM-dd"),
                FulfillmentDate = DateTime.Now.ToString("yyyy-MM-dd"),
                PaymentType = dto.PaymentType,
                BankAccountId = Convert.ToInt64(bankAccount.BillingoBankAccountId),
                PartnerId = Convert.ToInt64(partner.BillingoPartnerId),
                Paid = false,
                Electronic = true,
                Language = _options.Value.BillingoBillingSettings.Language,
                Currency = _options.Value.BillingoBillingSettings.Currency,
                BlockId = _options.Value.BillingoBillingSettings.ConstantBlockIdValue,
                Type = _options.Value.BillingoBillingSettings.Type,
            });

        private async Task<BillingoDocumentSettings> GetUpdatedBillingoDocumentSettingsAsync()
        {
            var newId = Guid.NewGuid();
            return await _billingoDocumentSettingsRepository.AddAsync(new BillingoDocumentSettings()
            {
                Id = newId,
                MediatedService = false,
                WithoutFinancialFulfillment = true,
                OnlinePayment = string.Empty,
                Round = "five",
                OrderNumber = newId.ToString(),
                PlaceId = 0
            });
        }
    }
}

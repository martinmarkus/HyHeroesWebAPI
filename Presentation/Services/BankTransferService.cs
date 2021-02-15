using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Infrastructure.Persistence.UnitOfWork;
using HyHeroesWebAPI.Presentation.ConfigObjects;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mappers.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.Extensions.Options;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class BankTransferService : IBankTransferService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IUserService _userService;
        private readonly IZipReaderService _zipReaderService;

        private readonly IBankTransferRepository _bankTransferRepository;
        private readonly IUserRepository _userRepository;
        private readonly IKreditPurchaseRepository _kreditPurchaseRepository;
        private readonly IFailedTransactionRepository _failedTransactionRepository;

        private readonly IBankTransferMapper _bankTransferMapper;

        private readonly IOptions<AppSettings> _options;

        private const int RANDOM_CODE_LENGTH = 4;
        private const int MAX_CODE_GENERATOR_TRY = 1000000;

        public BankTransferService(
            IUnitOfWork unitOfWork,
            IKreditPurchaseRepository kreditPurchaseRepository,
            IUserService userService,
            IZipReaderService zipReaderService,
            IUserRepository userRepository,
            IBankTransferRepository bankTransferRepository,
            IFailedTransactionRepository failedTransactionRepository,
            IBankTransferMapper bankTransferMapper,
            IOptions<AppSettings> options)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentException(nameof(unitOfWork));

            _failedTransactionRepository = failedTransactionRepository ?? throw new ArgumentException(nameof(failedTransactionRepository));
            _kreditPurchaseRepository = kreditPurchaseRepository ?? throw new ArgumentException(nameof(kreditPurchaseRepository));
            _userRepository = userRepository ?? throw new ArgumentException(nameof(userRepository));
            _bankTransferRepository = bankTransferRepository ?? throw new ArgumentException(nameof(bankTransferRepository));

            _userService = userService ?? throw new ArgumentException(nameof(userService));
            _zipReaderService = zipReaderService ?? throw new ArgumentException(nameof(zipReaderService));

            _bankTransferMapper = bankTransferMapper ?? throw new ArgumentException(nameof(bankTransferMapper));

            _options = options ?? throw new ArgumentException(nameof(options));
        }

        public async Task<StartedBankTransferDTO> StartBankTransferKreditPurchaseAsync(
            BankTransferPurchaseDTO purchaseDTO,
            string userName)
        {
            var user = await _userRepository.GetByUserNameAsync(userName);
            if (user == null)
            {
                throw new NotFoundException();
            }

            var transferCode = await GenerateValidTransferCodeAsync(user.Id, user.UserName);

            var currencyValue = GetCurrencyValue(purchaseDTO.KreditAmount);

            var newBankTransfer = _bankTransferMapper.MapToBankTransfer(
                purchaseDTO,
                currencyValue,
                transferCode,
                user.Id);

            await _bankTransferRepository.AddAsync(newBankTransfer);

            return new StartedBankTransferDTO()
            {
                TransferCode = transferCode,
                CurrencyValue = currencyValue,
                KreditValue = purchaseDTO.KreditAmount,
                SellerAccountOwner = _options.Value.BankTransferSellerData.SellerAccountOwner,
                SellerBankName = _options.Value.BankTransferSellerData.SellerBankName,
                AccountNumber = _options.Value.BankTransferSellerData.AccountNumber
            };
        }

        private async Task<string> GenerateValidTransferCodeAsync(Guid userId, string userName)
        {
            var codeGeneratingTryCount = 0;
            var existingUserTransfers = await _bankTransferRepository.GetTransfersByUserIdAsync(userId);

            while (codeGeneratingTryCount < MAX_CODE_GENERATOR_TRY)
            {
                var newCode = GetRandomTransferCode(userName);

                var isCodeFound = false;
                foreach (var transfer in existingUserTransfers)
                {
                    if (transfer.TransferCode.Equals(newCode, StringComparison.OrdinalIgnoreCase))
                    {
                        isCodeFound = true;
                        codeGeneratingTryCount++;
                        break;
                    }
                }

                if (!isCodeFound)
                {
                    return newCode;
                }
            }

            return GetRandomTransferCode(userName);
        }

        private int GetCurrencyValue(int selectedKreditAmount)
        {
            foreach (var type in _options.Value.BankTransferPurchaseTypes)
            {
                if (type.KreditValue == selectedKreditAmount)
                {
                    return type.GrossPrice;
                }
            }

            throw new MissingBankTransferTypeException();
        }

        private string GetRandomTransferCode(string userName)
        {
            var chars = "ABCDEFGHJKLMNPQRSTUVWXYZ23456789";
            return userName + "-" + 
                new string(Enumerable.Repeat(chars, RANDOM_CODE_LENGTH)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }

        public BankTransferTypeListDTO GetBankTransferPurchaseTypes()
        {
            var dto = _bankTransferMapper.MapToBankTransferPurchaseTypes(_options.Value.BankTransferPurchaseTypes);
            dto.Zips = _zipReaderService.ReadInZipData();

            return dto;
        }

        public async Task<BankTransferDTO> ApplyBankTransferAsync(string transferCode)
        {
            if (!transferCode.Contains("-"))
            {
                throw new Exception();
            }

            var assertUserName = transferCode.Split("-")[0];
            var user = await _userRepository.GetByUserNameAsync(assertUserName);
            if (user == null)
            {
                throw new NotFoundException();
            }

            var bankTransfer = await _bankTransferRepository.GetByTransferCodeAsync(
                user.Id,
                transferCode);

            if (bankTransfer == null || bankTransfer.IsActivated)
            {
                throw new NotFoundException();
            }

            var transaction = _unitOfWork.BeginTransaction();
            try
            {
                bankTransfer.IsActivated = true;
                await _unitOfWork.BankTransferRepository.UpdateAsync(bankTransfer);

                await _unitOfWork.KreditPurchaseRepository.AddAsync(new KreditPurchase()
                {
                    CurrencyValue = bankTransfer.CurrencyValue,
                    KreditValue = bankTransfer.KreditValue,
                    PaymentType = ApplicationCore.Enums.PaymentType.BankTransfer,
                    UserId = user.Id
                });

                await _userService.PurchaseKreditAsync(new KreditPurchaseTransactionDTO()
                {
                    CurrencyValue = bankTransfer.CurrencyValue,
                    KreditValue = bankTransfer.KreditValue,
                    UserName = user.UserName,
                    PaymentType = ApplicationCore.Enums.PaymentType.BankTransfer,
                    VevoAdoszam = bankTransfer.TaxNumber,
                    VevoAzonosito = user.Id.ToString(),
                    VevoEmail = bankTransfer.BillingEmail,
                    VevoNev = bankTransfer.BillingName,
                    VevoTelepules = bankTransfer.BankTransferBillingAddress.City,
                    VevoIrsz = bankTransfer.BankTransferBillingAddress.Zip,
                    VevoCim = bankTransfer.BankTransferBillingAddress.Street,
                    VevoMegjegyzes = bankTransfer.TransferCode,
                    VevoSendEmail = "true"
                });
                transaction.Commit();
            }
            catch (Exception e)
            {
                transaction.Rollback();
                transaction.Dispose();

                await _failedTransactionRepository.AddAsync(new FailedBillingTransaction()
                {
                    KreditAmount = bankTransfer.KreditValue,
                    CurrencyValue = bankTransfer.CurrencyValue,
                    ErrorMessage = e.Message,
                    FailDate = DateTime.Now,
                    PaymentType = ApplicationCore.Enums.PaymentType.BankTransfer,
                    UserId = user.Id
                });

                throw e;
            }

            transaction.Dispose();

            return _bankTransferMapper.MapToBankTransferDTO(bankTransfer);
        }

        public async Task<BankTransferListDTO> GetBankTransferTransactionsAsync(string userNameOrTransferCode) =>
            _bankTransferMapper.MapToBankTransferListDTO(
                await _bankTransferRepository.GetAllbyUserNameOrTransferCodeAsync(userNameOrTransferCode));
    }
}

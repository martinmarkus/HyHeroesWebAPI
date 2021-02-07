﻿using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Infrastructure.Persistence.UnitOfWork;
using HyHeroesWebAPI.Presentation.ConfigObjects;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mapper.Interfaces;
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
            IUserRepository userRepository,
            IBankTransferRepository bankTransferRepository,
            IFailedTransactionRepository failedTransactionRepository,
            IBankTransferMapper bankTransferMapper,
            IOptions<AppSettings> options)
        {
            _failedTransactionRepository = failedTransactionRepository ?? throw new ArgumentException(nameof(failedTransactionRepository));
            _unitOfWork = unitOfWork ?? throw new ArgumentException(nameof(unitOfWork));
            _kreditPurchaseRepository = kreditPurchaseRepository ?? throw new ArgumentException(nameof(kreditPurchaseRepository));
            _userService = userService ?? throw new ArgumentException(nameof(userService));
            _userRepository = userRepository ?? throw new ArgumentException(nameof(userRepository));
            _bankTransferRepository = bankTransferRepository ?? throw new ArgumentException(nameof(bankTransferRepository));
            
            _bankTransferMapper = bankTransferMapper ?? throw new ArgumentException(nameof(bankTransferMapper));

            _options = options ?? throw new ArgumentException(nameof(options));
        }

        public async Task<StartedBankTransferDTO> StartManualKreditPurchaseAsync(
            BankTransferPurchaseDTO customKreditPurchaseDTO,
            string userName)
        {
            var user = await _userRepository.GetByUserNameAsync(userName);
            if (user == null)
            {
                throw new NotFoundException();
            }

            var transferCode = string.Empty;
            var codeGeneratingTryCount = 0;
            var existingUserTransfers = await _bankTransferRepository.GetTransfersByUserIdAsync(user.Id);

            while (transferCode.Equals(string.Empty) && codeGeneratingTryCount < MAX_CODE_GENERATOR_TRY)
            {
                var newCode = GetRandomTransferCode();

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
                    transferCode = user.UserName + "-" + newCode;
                    break;
                }
            }
            if (transferCode.Equals(string.Empty))
            {
                transferCode = user.UserName + "-" + GetRandomTransferCode();
            }

            var currencyValue = 0;

            foreach (var type in _options.Value.BankTransferPurchaseTypes)
            {
                if (type.KreditValue == customKreditPurchaseDTO.KreditAmount)
                {
                    currencyValue = type.GrossPrice;
                    break;
                }
            }

            if (currencyValue == 0)
            {
                throw new MissingBankTransferTypeException();
            }

            var newBankTransfer = _bankTransferMapper.MapToBankTransfer(
                customKreditPurchaseDTO,
                currencyValue,
                transferCode,
                user.Id);

            await _bankTransferRepository.AddAsync(newBankTransfer);

            return new StartedBankTransferDTO()
            {
                TransferCode = transferCode,
                CurrencyValue = currencyValue,
                KreditValue = customKreditPurchaseDTO.KreditAmount,
                SellerAccountOwner = _options.Value.BankTransferSellerData.SellerAccountOwner,
                SellerBankName = _options.Value.BankTransferSellerData.SellerBankName,
                AccountNumber = _options.Value.BankTransferSellerData.AccountNumber
            };
        }

        public async Task ApplyBankTransferAsync(ApplyBankTransferDTO applyBankTransferDTO)
        {
            if (!applyBankTransferDTO.TransferCode.Contains("-"))
            {
                throw new Exception();
            }

            var assertUserName = applyBankTransferDTO.TransferCode.Split("-")[0];
            var user = await _userRepository.GetByUserNameAsync(assertUserName);
            if (user == null)
            {
                throw new NotFoundException();
            }

            var bankTransfer = await _bankTransferRepository.GetByTransferCodeAsync(
                user.Id,
                applyBankTransferDTO.TransferCode);

            if (bankTransfer == null)
            {
                throw new NotFoundException();
            }

            var transaction = _unitOfWork.BeginTransaction();
            try
            {
                bankTransfer.IsActivated = true;
                await _unitOfWork.BankTransferRepository.UpdateAsync(bankTransfer);

                user.Currency += Math.Abs(bankTransfer.KreditValue);
                await _userRepository.UpdateAsync(user);

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
                    VevoMegjegyzes = bankTransfer.TransferCode
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
        }

        private string GetRandomTransferCode()
        {
            var chars = "ABCDEFGHJKLMNPQRSTUVWXYZ23456789";
            return new string(Enumerable.Repeat(chars, RANDOM_CODE_LENGTH)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }
    }
}

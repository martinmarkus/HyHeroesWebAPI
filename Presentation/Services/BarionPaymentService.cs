using BarionClientLibrary;
using BarionClientLibrary.Operations.Common;
using BarionClientLibrary.Operations.PaymentState;
using BarionClientLibrary.Operations.StartPayment;
using BarionClientLibrary.RetryPolicies;
using HyHeroesWebAPI.ApplicationCore.DataObjects;
using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.ApplicationCore.Enums;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Presentation.ConfigObjects;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mapper.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class BarionPaymentService : IBarionPaymentService
    {
        private readonly IBarionPaymentMapper _barionPaymentMapper;
        private readonly IUserRepository _userRepository;
        private readonly IUserService _userService;

        private readonly IBarionTransactionRepository _barionTransactionRepository;
        private readonly IBarionBillingAddressRepository _barionBillingAddressRepository;
        private readonly IKreditPurchaseRepository _kreditPurchaseRepository;

        private readonly BarionClient _barionClient;

        private readonly IOptions<AppSettings> _options;

        public BarionPaymentService(
            BarionClient barionClient,
            IBarionPaymentMapper barionPaymentMapper,
            IUserRepository userRepository,
            IKreditPurchaseRepository kreditPurchaseRepository,
            IUserService userService,
            IBarionBillingAddressRepository barionBillingAddressRepository,
            IBarionTransactionRepository barionTransactionStartRepository,
            IOptions<AppSettings> options)
        {
            _barionClient = barionClient ?? throw new ArgumentException(nameof(barionClient));
            _userRepository = userRepository ?? throw new ArgumentException(nameof(userRepository));
            _kreditPurchaseRepository = kreditPurchaseRepository ?? throw new ArgumentException(nameof(kreditPurchaseRepository));
            _barionBillingAddressRepository = barionBillingAddressRepository ?? throw new ArgumentException(nameof(barionBillingAddressRepository));
            _barionTransactionRepository = barionTransactionStartRepository ?? throw new ArgumentException(nameof(barionTransactionStartRepository));

            _userService = userService ?? throw new ArgumentException(nameof(userService));
            _barionPaymentMapper = barionPaymentMapper ?? throw new ArgumentException(nameof(barionPaymentMapper));

            _options = options ?? throw new ArgumentException(nameof(options));
        }

        public async Task<BarionTransactionStateDTO> CheckBarionPaymentIdAsync(string paymentId)
        {
            var isGuid = Guid.TryParse(paymentId, out _);
            if (!isGuid)
            {
                throw new Exception();
            }

            var paymentIdGuidWithDashes = Guid.ParseExact(paymentId, "N");
            var barionTransaction = await _barionTransactionRepository.GetByBarionPaymentIdAsync(paymentIdGuidWithDashes);
            if (barionTransaction == null)
            {
                throw new NotFoundException();
            }

            return new BarionTransactionStateDTO()
            {
                TransactionState = barionTransaction.State.ToString()
            };
        }

        public BarionPurchaseTypeListDTO GetBarionPurchaseTypes() =>
            _barionPaymentMapper.MapToBarionPurchaseTypeListDTO(_options.Value.BarionPurchaseTypes);

        public async Task<InitializedBarionTransactionDTO> InitializeTransactionAsync(
            string userName, 
            BarionPaymentTransactionDTO paymentTransactionDTO)
        {
            var user = await _userRepository.GetByUserNameAsync(userName);

            if (user == null)
            {
                throw new NotFoundException();
            }

            _barionClient.RetryPolicy = new LinearRetry(TimeSpan.FromMilliseconds(500), 3);
            var gatewayURL = string.Empty;

            bool isSuccessful;
            try
            {
                var startPayment = _barionPaymentMapper.MapToBarionPaymentDTO(paymentTransactionDTO);
                var result = await _barionClient.ExecuteAsync<StartPaymentOperationResult>(startPayment);

                if (result.Errors.Length > 0)
                {
                    foreach (var error in result.Errors)
                    {
                        if (error.ErrorCode.Equals("InvalidUser", StringComparison.OrdinalIgnoreCase))
                        {
                            throw new MissingBarionPayeeException();
                        }
                    }
                }

                isSuccessful = result != null && result.IsOperationSuccessful;

                var barionTransaction = _barionPaymentMapper.MapToBarionTransaction(
                    paymentTransactionDTO,
                    result,
                    user.Id,
                    isSuccessful 
                        ? BarionTransactionState.Started
                        : BarionTransactionState.Error
                    );
                var addedBarionTransaction = await _barionTransactionRepository.AddAsync(barionTransaction);

                var billingAddress = _barionPaymentMapper.MapToBarionBillingAddress(
                    paymentTransactionDTO.BarionBillingAddressDTO,
                    addedBarionTransaction.Id);
                await _barionBillingAddressRepository.AddAsync(billingAddress);

                if (isSuccessful)
                {
                    gatewayURL = result.GatewayUrl;
                    var kreditPurchase = _barionPaymentMapper.MapToKreditPurchase(
                        paymentTransactionDTO,
                        user.Id);
                    await _kreditPurchaseRepository.AddAsync(kreditPurchase);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                if (e is MissingBarionPayeeException)
                {
                    throw e;
                }
            }

            return new InitializedBarionTransactionDTO() 
            {
                GatewayURL = gatewayURL
            };
        }

        public async Task ProcessBarionCallbackAsync(BarionCallbackDTO barionCallbackDTO)
        {
            if (!Guid.TryParse(barionCallbackDTO.PaymentId, out Guid result))
            {
                throw new Exception();
            }

            var barionTransaction = await _barionTransactionRepository
                .GetStartedByBarionPaymentIdAsync(result);

            if (barionTransaction == null)
            {
                throw new NotFoundException();
            }

            var operation = new GetPaymentStateOperation()
            {
                PaymentId = barionTransaction.PaymentId
            };

            var response = await _barionClient.ExecuteAsync<GetPaymentStateOperationResult>(operation);
        
            if (Convert.ToInt32(response.Total) != Convert.ToInt32(barionTransaction.TotalCost))
            // TODO: uncomment
            //response.Status != PaymentStatus.Succeeded || !response.CompletedAt.HasValue)
            {
                throw new BarionPaymentCallbackException();
            }

            barionTransaction.State = BarionTransactionState.Success;
            barionTransaction.IsFinished = true;
            barionTransaction.FinishDate = DateTime.Now;

            await _barionTransactionRepository.UpdateAsync(barionTransaction);

            await PurcahseKreditWithBillingAsync(barionTransaction);
        }

        private async Task PurcahseKreditWithBillingAsync(BarionTransaction barionTransaction)
        {
            var kreditUpload = new KreditPurchaseTransactionDTO()
            {
                KreditValue = Convert.ToInt32(barionTransaction.KreditAmount),
                VevoAdoszam = barionTransaction.TaxNumber,
                VevoAzonosito = barionTransaction.User.Id.ToString(),
                PaymentType = ApplicationCore.Enums.PaymentType.Barion,
                UserName = barionTransaction.User.UserName,
                VevoIrsz = barionTransaction.BarionBillingAddress.Zip,
                VevoTelepules = barionTransaction.BarionBillingAddress.City,
                VevoCim = barionTransaction.BarionBillingAddress.Street 
                    + barionTransaction.BarionBillingAddress.Street2
                    + barionTransaction.BarionBillingAddress.Street3,
                VevoEmail = barionTransaction.BillingEmail,
                VevoNev = barionTransaction.BillingName
            };

            var isBilled = await _userService.PurchaseKreditAsync(kreditUpload);

            if (!isBilled)
            {
                throw new BillingException();
            }
        }
    }
}

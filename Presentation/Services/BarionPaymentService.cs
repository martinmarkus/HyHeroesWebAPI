using BarionClientLibrary;
using BarionClientLibrary.Operations.PaymentState;
using BarionClientLibrary.Operations.StartPayment;
using BarionClientLibrary.RetryPolicies;
using HyHeroesWebAPI.ApplicationCore.DataObjects;
using HyHeroesWebAPI.ApplicationCore.Enums;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Infrastructure.Persistence.UnitOfWork;
using HyHeroesWebAPI.Infrastructure.Infrastructure.ConfigObjects;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mappers.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;
using BarionClientLibrary.Operations.Common;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class BarionPaymentService : IBarionPaymentService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IBarionPaymentMapper _barionPaymentMapper;
        private readonly IUserRepository _userRepository;
        private readonly IZipReaderService _zipReaderService;
        private readonly IBillingoService _billingoService;
        private readonly INotificationService _notificationService;
        private readonly IDiscordService _discordService;

        private readonly IBarionTransactionRepository _barionTransactionRepository;
        private readonly IBarionBillingAddressRepository _barionBillingAddressRepository;

        private readonly BarionClient _barionClient;

        private readonly IOptions<AppSettings> _options;
        private readonly ILogger<object> _logger;

        public BarionPaymentService(
            IUnitOfWork unitOfWork,
            BarionClient barionClient,
            IBarionPaymentMapper barionPaymentMapper,
            IUserRepository userRepository,
            INotificationService notificationService,
            IBillingoService billingoService,
            IBarionBillingAddressRepository barionBillingAddressRepository,
            IBarionTransactionRepository barionTransactionStartRepository,
            IZipReaderService zipReaderService,
            IDiscordService discordService,
            IOptions<AppSettings> options,
            ILogger<object> logger)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentException(nameof(unitOfWork));

            _barionClient = barionClient ?? throw new ArgumentException(nameof(barionClient));
            _userRepository = userRepository ?? throw new ArgumentException(nameof(userRepository));
            _barionBillingAddressRepository = barionBillingAddressRepository ?? throw new ArgumentException(nameof(barionBillingAddressRepository));
            _barionTransactionRepository = barionTransactionStartRepository ?? throw new ArgumentException(nameof(barionTransactionStartRepository));
            
            _discordService = discordService ?? throw new ArgumentException(nameof(discordService));
            _zipReaderService = zipReaderService ?? throw new ArgumentException(nameof(zipReaderService));
            _notificationService = notificationService ?? throw new ArgumentException(nameof(notificationService));
            _barionPaymentMapper = barionPaymentMapper ?? throw new ArgumentException(nameof(barionPaymentMapper));
            _billingoService = billingoService ?? throw new ArgumentException(nameof(billingoService));

            _options = options ?? throw new ArgumentException(nameof(options));

            _logger = logger;
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

        public BarionPurchaseTypeListDTO GetBarionPurchaseTypes()
        {
            var dto = _barionPaymentMapper.MapToBarionPurchaseTypeListDTO(_options.Value.BarionPurchaseTypes);
            dto.Zips = _zipReaderService.ReadInZipData();

            return dto;
        }

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

        public async Task ProcessBarionCallbackAsync(string paymentId)
        {
            if (!Guid.TryParse(paymentId, out Guid result))
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

            
            var user = await _userRepository.GetByIdAsync(barionTransaction.UserId);
            if (user == null)
            {
                throw new NotFoundException();
            }

            var transaction = _unitOfWork.BeginTransaction();
            try
            {
                _logger.LogInformation("ASDOPERATION: " + JsonConvert.SerializeObject(operation));
                var response = await _barionClient.ExecuteAsync<GetPaymentStateOperationResult>(operation);
                _logger.LogInformation("ASDRESPONSE: " + JsonConvert.SerializeObject(response));

                if (Convert.ToInt32(response.Total) != Convert.ToInt32(barionTransaction.TotalCost)
                    || (response.Status != PaymentStatus.Succeeded && response.Status != PaymentStatus.PartiallySucceeded)
                    || !response.CompletedAt.HasValue
                    )
                {
                    throw new BarionPaymentCallbackException();
                }

                user.Currency += Math.Abs(Convert.ToInt32(barionTransaction.KreditAmount));
                await _unitOfWork.UserRepository.UpdateAsync(user);

                barionTransaction.State = BarionTransactionState.Success;
                barionTransaction.IsFinished = true;
                barionTransaction.FinishDate = DateTime.Now;

                await _unitOfWork.BarionTransactionRepository.UpdateAsync(barionTransaction);

                await _billingoService.CreateBillAsync(new CreateBillingoBillDTO()
                {
                    Address = barionTransaction.BarionBillingAddress.Street
                        + barionTransaction.BarionBillingAddress.Street2
                        + barionTransaction.BarionBillingAddress.Street3,

                    City = barionTransaction.BarionBillingAddress.City,
                    CountryCode = barionTransaction.BarionBillingAddress.Country,
                    ZipCode = barionTransaction.BarionBillingAddress.Zip,
                    ClientEmail = barionTransaction.BillingEmail,
                    ClientName = barionTransaction.BillingName,
                    CurrencyValue = Convert.ToInt32(barionTransaction.TotalCost),
                    KreditValue = Convert.ToInt32(barionTransaction.KreditAmount),
                    PaymentType = BillingoPaymentMethod.BARION.ToString().ToLower(),
                    Taxnumber = barionTransaction.TaxNumber,
                    UserName = barionTransaction.User.UserName,
                    Comment = barionTransaction.PaymentId.ToString()
                });

                var kreditPurchase = _barionPaymentMapper.MapToKreditPurchase(barionTransaction);
                await _unitOfWork.KreditPurchaseRepository.AddAsync(kreditPurchase);

                await _notificationService.CreateKreditPurchaseNotificationAsync(new KreditPurchaseNotification()
                {
                    KreditValue = Convert.ToInt32(barionTransaction.KreditAmount),
                    PaymentType = "Barion",
                    UserId = user.Id
                });

                await _discordService.SendMessageToStaffAsync(string.Format(
                    _options.Value.DiscordSettings.PurchaseMessage,
                    barionTransaction.User.UserName,
                    Convert.ToInt32(barionTransaction.KreditAmount),
                    Convert.ToInt32(barionTransaction.TotalCost),
                    "Barion"));

                transaction.Commit();
            }
            catch (Exception e)
            {
                transaction.Rollback();
                transaction.Dispose();
                throw e;
            }

            transaction.Dispose();
        }

        public async Task ProcessBarionRedirectAsync(string paymentId)
        {
            if (!Guid.TryParse(paymentId, out Guid result))
            {
                throw new Exception();
            }

            var barionTransaction = await _barionTransactionRepository
                .GetStartedByBarionPaymentIdAsync(result);

            if (barionTransaction == null || !barionTransaction.IsFinished)
            {
                throw new NotFoundException();
            }
        }
    }
}

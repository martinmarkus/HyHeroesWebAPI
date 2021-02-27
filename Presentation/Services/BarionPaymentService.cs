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

        private readonly IBarionTransactionRepository _barionTransactionRepository;
        private readonly IBarionBillingAddressRepository _barionBillingAddressRepository;
        private readonly IKreditPurchaseRepository _kreditPurchaseRepository;

        private readonly BarionClient _barionClient;

        private readonly IOptions<AppSettings> _options;

        public BarionPaymentService(
            IUnitOfWork unitOfWork,
            BarionClient barionClient,
            IBarionPaymentMapper barionPaymentMapper,
            IUserRepository userRepository,
            IKreditPurchaseRepository kreditPurchaseRepository,
            INotificationService notificationService,
            IBillingoService billingoService,
            IBarionBillingAddressRepository barionBillingAddressRepository,
            IBarionTransactionRepository barionTransactionStartRepository,
            IZipReaderService zipReaderService,
            IOptions<AppSettings> options)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentException(nameof(unitOfWork));

            _barionClient = barionClient ?? throw new ArgumentException(nameof(barionClient));
            _userRepository = userRepository ?? throw new ArgumentException(nameof(userRepository));
            _kreditPurchaseRepository = kreditPurchaseRepository ?? throw new ArgumentException(nameof(kreditPurchaseRepository));
            _barionBillingAddressRepository = barionBillingAddressRepository ?? throw new ArgumentException(nameof(barionBillingAddressRepository));
            _barionTransactionRepository = barionTransactionStartRepository ?? throw new ArgumentException(nameof(barionTransactionStartRepository));

            _zipReaderService = zipReaderService ?? throw new ArgumentException(nameof(zipReaderService));
            _notificationService = notificationService ?? throw new ArgumentException(nameof(notificationService));
            _barionPaymentMapper = barionPaymentMapper ?? throw new ArgumentException(nameof(barionPaymentMapper));
            _billingoService = billingoService ?? throw new ArgumentException(nameof(billingoService));

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

            var user = await _userRepository.GetByIdAsync(barionTransaction.UserId);
            if (user == null)
            {
                throw new NotFoundException();
            }

            var transaction = _unitOfWork.BeginTransaction();
            try
            {
                var response = await _barionClient.ExecuteAsync<GetPaymentStateOperationResult>(operation);

                if (Convert.ToInt32(response.Total) != Convert.ToInt32(barionTransaction.TotalCost))
                // TODO: uncomment
                //response.Status != PaymentStatus.Succeeded || !response.CompletedAt.HasValue)
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
                    UserName = barionTransaction.User.UserName
                });

                var kreditPurchase = _barionPaymentMapper.MapToKreditPurchase(barionTransaction);
                await _unitOfWork.KreditPurchaseRepository.AddAsync(kreditPurchase);

                await _notificationService.CreateKreditPurchaseNotificationAsync(new KreditPurchaseNotification()
                {
                    KreditValue = Convert.ToInt32(barionTransaction.KreditAmount),
                    PaymentType = "Barion",
                    UserId = user.Id
                });

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
    }
}

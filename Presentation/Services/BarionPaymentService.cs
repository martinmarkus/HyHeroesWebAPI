using BarionClientLibrary;
using BarionClientLibrary.Operations.StartPayment;
using BarionClientLibrary.RetryPolicies;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Presentation.ConfigObjects;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mapper.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class BarionPaymentService : IBarionPaymentService
    {
        private readonly IBarionPaymentMapper _barionPaymentMapper;
        private readonly IUserRepository _userRepository;
        private readonly IHttpRequestService _httpRequestService;

        private readonly IBarionTransactionRepository _barionTransactionStartRepository;
        private readonly IBarionBillingAddressRepository _barionBillingAddressRepository;
        private readonly IKreditPurchaseRepository _kreditPurchaseRepository;

        private readonly BarionClient _barionClient;

        private readonly IOptions<AppSettings> _options;

        public BarionPaymentService(
            BarionClient barionClient,
            IBarionPaymentMapper barionPaymentMapper,
            IHttpRequestService httpRequestService,
            IUserRepository userRepository,
            IKreditPurchaseRepository kreditPurchaseRepository,
            IBarionBillingAddressRepository barionBillingAddressRepository,
            IBarionTransactionRepository barionTransactionStartRepository,
            IOptions<AppSettings> options)
        {
            _barionClient = barionClient ?? throw new ArgumentException(nameof(barionClient));
            _userRepository = userRepository ?? throw new ArgumentException(nameof(userRepository));
            _kreditPurchaseRepository = kreditPurchaseRepository ?? throw new ArgumentException(nameof(kreditPurchaseRepository));
            _barionBillingAddressRepository = barionBillingAddressRepository ?? throw new ArgumentException(nameof(barionBillingAddressRepository));
            _barionTransactionStartRepository = barionTransactionStartRepository ?? throw new ArgumentException(nameof(barionTransactionStartRepository));

            _httpRequestService = httpRequestService ?? throw new ArgumentException(nameof(httpRequestService));
            _barionPaymentMapper = barionPaymentMapper ?? throw new ArgumentException(nameof(barionPaymentMapper));

            _options = options ?? throw new ArgumentException(nameof(options));
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

                isSuccessful = result != null && result.IsOperationSuccessful;

                var barionTransaction = _barionPaymentMapper.MapToBarionTransaction(
                    paymentTransactionDTO,
                    result,
                    user.Id,
                    isSuccessful 
                        ? ApplicationCore.Enums.BarionTransactionState.Success
                        : ApplicationCore.Enums.BarionTransactionState.Error
                    );
                var addedBarionTransaction = await _barionTransactionStartRepository.AddAsync(barionTransaction);

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
            }

            return new InitializedBarionTransactionDTO() 
            {
                GatewayURL = gatewayURL
            };
        }

        public async Task ProcessBarionCallbackAsync(BarionCallbackDTO barionCallbackDTO)
        {
            throw new NotImplementedException();
        }
    }
}

using BarionClientLibrary;
using BarionClientLibrary.Operations.StartPayment;
using BarionClientLibrary.RetryPolicies;
using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mapper.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
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

        public BarionPaymentService(
            BarionClient barionClient,
            IBarionPaymentMapper barionPaymentMapper,
            IHttpRequestService httpRequestService,
            IUserRepository userRepository,
            IKreditPurchaseRepository kreditPurchaseRepository,
            IBarionBillingAddressRepository barionBillingAddressRepository,
            IBarionTransactionRepository barionTransactionStartRepository)
        {
            _barionClient = barionClient ?? throw new ArgumentException(nameof(barionClient));
            _userRepository = userRepository ?? throw new ArgumentException(nameof(userRepository));
            _kreditPurchaseRepository = kreditPurchaseRepository ?? throw new ArgumentException(nameof(kreditPurchaseRepository));
            _barionBillingAddressRepository = barionBillingAddressRepository ?? throw new ArgumentException(nameof(barionBillingAddressRepository));
            _barionTransactionStartRepository = barionTransactionStartRepository ?? throw new ArgumentException(nameof(barionTransactionStartRepository));

            _httpRequestService = httpRequestService ?? throw new ArgumentException(nameof(httpRequestService));
            _barionPaymentMapper = barionPaymentMapper ?? throw new ArgumentException(nameof(barionPaymentMapper));
        }

        public async Task<bool> InitializeTransactionAsync(BarionPaymentTransactionDTO paymentTransactionDTO)
        {
            var user = await _userRepository.GetByUserNameAsync(paymentTransactionDTO.UserName);

            if (user == null)
            {
                throw new NotFoundException();
            }

            _barionClient.RetryPolicy = new LinearRetry(TimeSpan.FromMilliseconds(500), 3);

            var isSuccessful = false;
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

            return isSuccessful;
        }

        public async Task ProcessBarionCallbackAsync(BarionCallbackDTO barionCallbackDTO)
        {
            throw new NotImplementedException();
        }
    }
}

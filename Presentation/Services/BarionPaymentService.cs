using BarionClientLibrary;
using BarionClientLibrary.Operations.StartPayment;
using BarionClientLibrary.RetryPolicies;
using HyHeroesWebAPI.ApplicationCore.Entities;
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

        private readonly BarionClient _barionClient;

        public BarionPaymentService(
            BarionClient barionClient,
            IBarionPaymentMapper barionPaymentMapper,
            IHttpRequestService httpRequestService,
            IUserRepository userRepository,
            IBarionBillingAddressRepository barionBillingAddressRepository,
            IBarionTransactionRepository barionTransactionStartRepository)
        {
            _barionClient = barionClient ?? throw new ArgumentException(nameof(barionClient));
            _userRepository = userRepository ?? throw new ArgumentException(nameof(userRepository));
            _barionBillingAddressRepository = barionBillingAddressRepository ?? throw new ArgumentException(nameof(barionBillingAddressRepository));
            _barionTransactionStartRepository = barionTransactionStartRepository ?? throw new ArgumentException(nameof(barionTransactionStartRepository));

            _httpRequestService = httpRequestService ?? throw new ArgumentException(nameof(httpRequestService));
            _barionPaymentMapper = barionPaymentMapper ?? throw new ArgumentException(nameof(barionPaymentMapper));
        }

        public async Task<bool> InitializeTransactionAsync(BarionPaymentTransactionDTO paymentTransactionDTO)
        {
            _barionClient.RetryPolicy = new LinearRetry(TimeSpan.FromMilliseconds(500), 3);

            var result = default(StartPaymentOperationResult);
            try
            {
                var startPayment = _barionPaymentMapper.MapToBarionPaymentDTO(paymentTransactionDTO);
                result = await _barionClient.ExecuteAsync<StartPaymentOperationResult>(startPayment);

                if (result.IsOperationSuccessful)
                {
                    await _barionTransactionStartRepository.AddAsync(new BarionTransaction()
                    {
                    });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return result != null && result.IsOperationSuccessful;
        }

        public async Task ProcessBarionCallbackAsync(BarionCallbackDTO barionCallbackDTO)
        {
            throw new NotImplementedException();
        }
    }
}

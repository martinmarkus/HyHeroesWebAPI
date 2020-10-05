using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Presentation.Facades.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    [Obsolete]
    public class DbListenerService : IDbListenerService
    {
        private readonly IPurchasedProductRepository _purchasedProductRepository;
        private readonly IRecurringTaskFacade _recurringTaskFacade;

        private int _interval;
        private CancellationTokenSource _cancellationToken;

        public DbListenerService(
            IPurchasedProductRepository purchasedProductRepository,
            IRecurringTaskFacade recurringTaskFacade)
        {
            _purchasedProductRepository = purchasedProductRepository ?? throw new ArgumentException(nameof(purchasedProductRepository));
            _recurringTaskFacade = recurringTaskFacade ?? throw new ArgumentException(nameof(recurringTaskFacade));
        }

        public void Start(int interval = 60)
        {
            _interval = interval;
            _cancellationToken = new CancellationTokenSource();

            _recurringTaskFacade.StartRecurringTask(
                ExecuteDbCheck,
                _interval,
                _cancellationToken.Token);
        }

        public void Stop()
        {
            _cancellationToken.Cancel();
        }

        private async void ExecuteDbCheck()
        {
            await ExecuteExpirationCheckAsync();
            await ExecuteFailedActivationCheckAsync();
        }

        private async Task ExecuteExpirationCheckAsync()
        {
            var expiredPurchases = await _purchasedProductRepository.GetAllExpiredPurchasedProductsAsync(true);

            if (expiredPurchases == null || expiredPurchases.Count == 0)
            {
                return;
            }

            //await _gameServerMessageService.SendPurchaseExpirationListAsync(expiredPurchases);

            foreach (var purchase in expiredPurchases)
            {
                purchase.IsExpirationVerified = true;
            }

            await _purchasedProductRepository.UpdateAllAsync(expiredPurchases);
        }

        private async Task ExecuteFailedActivationCheckAsync()
        {
            var existingPurchases = await _purchasedProductRepository.GetAllUnverifiedPurchasedProductsAsync(true);

            if (existingPurchases == null || existingPurchases.Count == 0)
            {
                return;
            }

            //await _gameServerMessageService.SendPurchaseActivationListAsync(existingPurchases);

            foreach (var purchase in existingPurchases)
            {
                purchase.IsVerified = true;
            }

            await _purchasedProductRepository.UpdateAllAsync(existingPurchases);
        }
    }
}

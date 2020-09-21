using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Presentation.Services.GameServerServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.GameServerServices
{
    [Obsolete]
    public class GameServerMessageService : IGameServerMessageService
    { 
        private readonly IHttpRequestService _httpRequestService;

        public GameServerMessageService(IHttpRequestService httpRequestService)
        {
            _httpRequestService = httpRequestService ?? throw new ArgumentException(nameof(httpRequestService));
        }

        public Task SendPurchaseActivationListAsync(IList<PurchasedProduct> purchasedProduct)
        {
            throw new NotImplementedException();
        }

        public Task SendPurchaseActivationAsync(PurchasedProduct purchasedProduct)
        {
            throw new NotImplementedException();
        }

        public Task SendPurchaseExpirationListAsync(IList<PurchasedProduct> purchasedProduct)
        {
            throw new NotImplementedException();
        }

        public Task SendPurchaseExpirationAsync(PurchasedProduct purchasedProduct)
        {
            throw new NotImplementedException();
        }
    }
}

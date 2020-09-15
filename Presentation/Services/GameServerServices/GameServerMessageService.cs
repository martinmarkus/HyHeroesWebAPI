using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Presentation.Services.GameServerServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.GameServerServices
{
    public class GameServerMessageService : IGameServerMessageService
    { 
        private readonly IHttpRequestService _httpRequestService;

        public GameServerMessageService(IHttpRequestService httpRequestService)
        {
            _httpRequestService = httpRequestService ?? throw new ArgumentException(nameof(httpRequestService));
        }

        public async Task SendPurchaseActivationListAsync(IList<PurchasedProduct> purchasedProduct)
        {
            throw new NotImplementedException();
        }

        public async Task SendPurchaseActivationAsync(PurchasedProduct purchasedProduct)
        {
            throw new NotImplementedException();
        }

        public async Task SendPurchaseExpirationListAsync(IList<PurchasedProduct> purchasedProduct)
        {
            throw new NotImplementedException();
        }

        public async Task SendPurchaseExpirationAsync(PurchasedProduct purchasedProduct)
        {
            throw new NotImplementedException();
        }
    }
}

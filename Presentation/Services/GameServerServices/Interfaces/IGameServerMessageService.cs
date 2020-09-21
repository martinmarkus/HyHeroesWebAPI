using HyHeroesWebAPI.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.GameServerServices.Interfaces
{
    [Obsolete]
    public interface IGameServerMessageService
    {
        Task SendPurchaseActivationAsync(PurchasedProduct purchasedProduct);
        Task SendPurchaseActivationListAsync(IList<PurchasedProduct> purchasedProducts);

        Task SendPurchaseExpirationAsync(PurchasedProduct purchasedProduct);
        Task SendPurchaseExpirationListAsync(IList<PurchasedProduct> purchasedProducts);
    }
}

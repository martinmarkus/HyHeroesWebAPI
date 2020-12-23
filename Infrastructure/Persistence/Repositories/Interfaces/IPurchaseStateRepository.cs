using HyHeroesWebAPI.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface IPurchaseStateRepository : IAsyncRepository<PurchaseState>
    {
        Task<IList<PurchaseState>> AddNewStateForEveryGameServersAsync(PurchaseState purchaseState);

        Task<IList<PurchaseState>> GetByPurchasedProductIdAsync(Guid purchasedProductId);
    }
}

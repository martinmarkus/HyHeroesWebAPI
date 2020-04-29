using HyHeroesWebAPI.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface IPurchasedProductRepository : IAsyncRepository<PurchasedProduct>
    {
        Task<IList<PurchasedProduct>> GetAllUnverifiedPurchasedProductsAsync();

        Task<IList<PurchasedProduct>> GetAllVerifiedPurchasedProductsAsync();

        Task<IList<PurchasedProduct>> GetAllByIdsAsync(IList<Guid> ids);

        Task<IList<PurchasedProduct>> GetAllActivePurchasesByUserIdAsync(Guid userId);

        Task<IList<PurchasedProduct>> GetAllActivePurchasesByEmailAsync(string email);

        Task UpdateAllAsync(IList<PurchasedProduct> purchasedProducts);

        Task<IList<PurchasedProduct>> GetUnverifiedExpiredPurchasedProductsAsync();

        Task<IList<PurchasedProduct>> GetAllExpiredPurchasedProductsAsync();
    }
}

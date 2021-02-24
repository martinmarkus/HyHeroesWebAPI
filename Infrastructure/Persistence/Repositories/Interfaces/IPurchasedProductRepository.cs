using HyHeroesWebAPI.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface IPurchasedProductRepository : IAsyncRepository<PurchasedProduct>
    {
        Task<IList<PurchasedProduct>> GetUnverifiedPurchasedProductsByServerIdAsync(Guid serverId, bool justRanks);

        Task<IList<PurchasedProduct>> GetAllVerifiedPurchasedProductsAsync(bool justRanks);

        Task<IList<PurchasedProduct>> GetAllByIdsAsync(IList<Guid> ids, bool justRanks);

        Task UpdateAllAsync(IList<PurchasedProduct> purchasedProducts);

        Task<IList<PurchasedProduct>> GetUnverifiedExpiredPurchasedProductsAsync(Guid serverId, bool justRanks);

        Task<IList<PurchasedProduct>> GetAllExpiredPurchasedProductsAsync(bool justRanks);

        Task<IList<PurchasedProduct>> GetAllActivePurchasesByUserNameAsync(string userName, bool justRanks);

        Task<IList<PurchasedProduct>> GetAllActivePurchasesByEmailAsync(string email, bool justRanks);

        Task<IList<PurchasedProduct>> GetAllNonRepeatablePermanentPurchasesByUserNameAsync(string userName, Guid productId, bool justRanks);

        Task<PurchasedProduct> GetRepeatableTemporarytPurchaseByUserNameAsync(string userName, Guid productId, bool justRanks);

        Task<IList<PurchasedProduct>> GetAllPurchasesGroupByMonthAsync();  

        Task<IList<PurchasedProduct>> GetPurchasesOfActualDayAsync();

        Task<IList<PurchasedProduct>> GetPurchasesOfActualWeekAsync();

        Task<int> GetCountOfOverallPurchasesAsync();

        Task<IList<PurchasedProduct>> GetAllUnverifiedByIdsAsync(IList<Guid> ids, bool justRanks);

        Task<IList<PurchasedProduct>> GetAllByUserNameAsync(string userName, bool justRanks);

        Task<IList<PurchasedProduct>> GetAllByUserNameAsync(string userName);

        Task<IList<PurchasedProduct>> GetAllWithExceptingByUserNameAsync(Guid purchaseForExceptingId, string userName, bool justRanks);
        
        Task<IList<PurchasedProduct>> GetLastPurchasesAsync(int purchaseCount);
    }
}

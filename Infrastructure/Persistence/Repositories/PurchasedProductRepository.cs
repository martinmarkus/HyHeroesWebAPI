using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class PurchasedProductRepository : AsyncRepository<PurchasedProduct>, IPurchasedProductRepository
    {
        public PurchasedProductRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IList<PurchasedProduct>> GetAllUnverifiedPurchasedProductsAsync() =>
           (await GetPurchases())
                .Where(purchasedProduct => !purchasedProduct.IsVerified)
                .ToList();

        public async Task<IList<PurchasedProduct>> GetAllVerifiedPurchasedProductsAsync() =>
           (await GetPurchases())
                .Where(purchasedProduct => purchasedProduct.IsVerified)
                .ToList();


        public async Task<IList<PurchasedProduct>> GetAllByIdsAsync(IList<Guid> ids) =>
           (await GetPurchases())
                .Where(purchasedProduct => ids.Contains(purchasedProduct.Id)
                    && purchasedProduct.IsVerified)
                .ToList();

        public async Task UpdateAllAsync(IList<PurchasedProduct> purchasedProducts)
        {
            foreach (var purchasedProduct in purchasedProducts)
            {
                await UpdateAsync(purchasedProduct);
            }
        }

        public async Task<IList<PurchasedProduct>> GetUnverifiedExpiredPurchasedProductsAsync() =>
           (await GetPurchases())
                .Where(purchasedProduct => 
                    !purchasedProduct.IsPermanent
                    && purchasedProduct.IsVerified
                    && !purchasedProduct.IsExpirationVerified
                    && purchasedProduct.PurchaseDate.AddDays(
                    Math.Abs(purchasedProduct.ValidityPeriodInMonths * 30)) < DateTime.Now)
                .ToList();

        public async Task<IList<PurchasedProduct>> GetAllExpiredPurchasedProductsAsync() =>
           (await GetPurchases())
                .Where(purchasedProduct =>
                    !purchasedProduct.IsPermanent
                    && purchasedProduct.IsVerified
                    && purchasedProduct.PurchaseDate.AddDays(
                    Math.Abs(purchasedProduct.ValidityPeriodInMonths * 30)) < DateTime.Now)
                .ToList();

        public async Task<IList<PurchasedProduct>> GetAllActivePurchasesByUserIdAsync(Guid userId) =>
           (await GetPurchases())
                .Where(purchasedProduct => 
                    purchasedProduct.UserId == userId
                    && purchasedProduct.PurchaseDate.AddDays(
                    Math.Abs(purchasedProduct.ValidityPeriodInMonths * 30)) >= DateTime.Now)
                .ToList();

        public async Task<IList<PurchasedProduct>> GetAllActivePurchasesByEmailAsync(string email) =>
           (await GetPurchases())
               .Where(purchasedProduct =>
               purchasedProduct.User.Email.Equals(email, StringComparison.OrdinalIgnoreCase)
               && purchasedProduct.PurchaseDate.AddDays(
               Math.Abs(purchasedProduct.ValidityPeriodInMonths * 30)) >= DateTime.Now)
           .ToList();

        private async Task<IList<PurchasedProduct>> GetPurchases() =>
           await _dbContext.PurchasedProducts
               .Include(purchasedProduct => purchasedProduct.Product)
               .Include(purchasedProduct => purchasedProduct.User)
               .ThenInclude(user => user.Role)
               .Where(purchasedProduct =>
                   purchasedProduct.IsActive)
            .ToListAsync();
    }
}

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
            await _dbContext.PurchasedProducts
                .Include(purchasedProduct => purchasedProduct.Product)
                .Include(purchasedProduct => purchasedProduct.User)
                .ThenInclude(user => user.Role)
                .Where(purchasedProduct => !purchasedProduct.IsVerified
                    && purchasedProduct.IsActive)
                .ToListAsync();

        public async Task<IList<PurchasedProduct>> GetAllVerifiedPurchasedProductsAsync() =>
            await _dbContext.PurchasedProducts
                .Include(purchasedProduct => purchasedProduct.Product)
                .Include(purchasedProduct => purchasedProduct.User)
                .ThenInclude(user => user.Role)
                .Where(purchasedProduct => purchasedProduct.IsVerified
                    && purchasedProduct.IsActive)
                .ToListAsync();


        public async Task<IList<PurchasedProduct>> GetAllByIdsAsync(IList<Guid> ids)
        {
            return await _dbContext.PurchasedProducts
                .Include(purchasedProduct => purchasedProduct.Product)
                .Include(purchasedProduct => purchasedProduct.User)
                .ThenInclude(user => user.Role)
                .Where(purchasedProduct => ids.Contains(purchasedProduct.Id)
                    && purchasedProduct.IsVerified
                    && purchasedProduct.IsActive)
                .ToListAsync();
        }

        public async Task UpdateAllAsync(IList<PurchasedProduct> purchasedProducts)
        {
            foreach (var purchasedProduct in purchasedProducts)
            {
                await UpdateAsync(purchasedProduct);
            }
        }

        public async Task<IList<PurchasedProduct>> GetUnverifiedExpiredPurchasedProductsAsync() =>
            await _dbContext.PurchasedProducts
                .Include(purchasedProduct => purchasedProduct.Product)
                .Include(purchasedProduct => purchasedProduct.User)
                .ThenInclude(user => user.Role)
                .Where(purchasedProduct => 
                    !purchasedProduct.IsPermanent
                    && purchasedProduct.IsVerified
                    && !purchasedProduct.IsExpirationVerified
                    && purchasedProduct.IsActive
                    && purchasedProduct.PurchaseDate.AddDays(
                    Math.Abs(purchasedProduct.ValidityPeriodInMonths * 30)) < DateTime.Now)
                .ToListAsync();

        public async Task<IList<PurchasedProduct>> GetAllExpiredPurchasedProductsAsync() =>
            await _dbContext.PurchasedProducts
                .Include(purchasedProduct => purchasedProduct.Product)
                .Include(purchasedProduct => purchasedProduct.User)
                .ThenInclude(user => user.Role)
                .Where(purchasedProduct =>
                    !purchasedProduct.IsPermanent
                    && purchasedProduct.IsVerified
                    && purchasedProduct.IsActive
                    && purchasedProduct.PurchaseDate.AddDays(
                    Math.Abs(purchasedProduct.ValidityPeriodInMonths * 30)) < DateTime.Now)
                .ToListAsync();

        public async Task<IList<PurchasedProduct>> GetAllActivePurchasesByUserIdAsync(Guid userId) =>
            await _dbContext.PurchasedProducts
                .Include(purchasedProduct => purchasedProduct.Product)
                .Include(purchasedProduct => purchasedProduct.User)
                .ThenInclude(user => user.Role)
                .Where(purchasedProduct => 
                    purchasedProduct.IsActive
                    && purchasedProduct.UserId == userId
                    && purchasedProduct.PurchaseDate.AddDays(
                    Math.Abs(purchasedProduct.ValidityPeriodInMonths * 30)) >= DateTime.Now)
                .ToListAsync();

        public async Task<IList<PurchasedProduct>> GetAllActivePurchasesByEmailAsync(string email) =>
            await _dbContext.PurchasedProducts
                .Include(purchasedProduct => purchasedProduct.Product)
                .Include(purchasedProduct => purchasedProduct.User)
                .ThenInclude(user => user.Role)
                .Where(purchasedProduct =>
                    purchasedProduct.IsActive
                    && purchasedProduct.User.Email.Equals(email, StringComparison.OrdinalIgnoreCase)
                    && purchasedProduct.PurchaseDate.AddDays(
                    Math.Abs(purchasedProduct.ValidityPeriodInMonths * 30)) >= DateTime.Now)
                .ToListAsync();
    }
}

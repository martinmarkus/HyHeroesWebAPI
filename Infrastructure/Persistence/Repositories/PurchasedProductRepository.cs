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


        public async override Task<PurchasedProduct> GetByIdAsync(Guid id) =>
            (await GetPurchases(false))
                .Where(purchasedProduct => purchasedProduct.Id == id && purchasedProduct.IsActive)
                .FirstOrDefault();

        public async Task<IList<PurchasedProduct>> GetAllUnverifiedPurchasedProductsAsync(bool justRanks) =>
           (await GetPurchases(justRanks))
                .Where(purchasedProduct => !purchasedProduct.IsVerified)
                .ToList();

        public async Task<IList<PurchasedProduct>> GetAllVerifiedPurchasedProductsAsync(bool justRanks) =>
           (await GetPurchases(justRanks))
                .Where(purchasedProduct => purchasedProduct.IsVerified)
                .ToList();


        public async Task<IList<PurchasedProduct>> GetAllByIdsAsync(IList<Guid> ids, bool justRanks) =>
           (await GetPurchases(justRanks))
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

        public async Task<IList<PurchasedProduct>> GetUnverifiedExpiredPurchasedProductsAsync(bool justRanks) =>
           (await GetPurchases(justRanks))
                .Where(purchasedProduct => 
                    !purchasedProduct.IsPermanent
                    && purchasedProduct.IsVerified
                    && !purchasedProduct.IsExpirationVerified
                    && purchasedProduct.PurchaseDate.AddDays(
                    Math.Abs(purchasedProduct.ValidityPeriodInMonths * 30)) < DateTime.Now)
                .ToList();

        public async Task<IList<PurchasedProduct>> GetAllExpiredPurchasedProductsAsync(bool justRanks) =>
           (await GetPurchases(justRanks))
                .Where(purchasedProduct =>
                    !purchasedProduct.IsPermanent
                    && purchasedProduct.IsVerified
                    && purchasedProduct.PurchaseDate.AddDays(
                    Math.Abs(purchasedProduct.ValidityPeriodInMonths * 30)) < DateTime.Now)
                .ToList();

        public async Task<IList<PurchasedProduct>> GetAllActivePurchasesByUserNameAsync(string userName, bool justRanks) =>
        (await GetPurchases(justRanks))
                .Where(purchasedProduct =>
                    purchasedProduct.User.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase)
                    && ((purchasedProduct.PurchaseDate.AddDays(
                    Math.Abs(purchasedProduct.ValidityPeriodInMonths * 30)) >= DateTime.Now)
                    || purchasedProduct.IsPermanent))
                .ToList();

        public async Task<IList<PurchasedProduct>> GetAllActivePurchasesByEmailAsync(string email, bool justRanks) =>
           (await GetPurchases(justRanks))
               .Where(purchasedProduct =>
               purchasedProduct.User.Email.Equals(email, StringComparison.OrdinalIgnoreCase)
               && ((purchasedProduct.PurchaseDate.AddDays(
               Math.Abs(purchasedProduct.ValidityPeriodInMonths * 30)) >= DateTime.Now)
               || purchasedProduct.IsPermanent))
           .ToList();

        public async Task<IList<PurchasedProduct>> GetAllNonRepeatablePermanentPurchasesByUserNameAsync(string userName, Guid productId, bool justRanks) =>
            (await GetAllActivePurchasesByUserNameAsync(userName, justRanks))
                 .Where(purchasedProduct =>
                 purchasedProduct.ProductId == productId
                 && purchasedProduct.IsRepeatable == false
                 && purchasedProduct.IsPermanent == true)
            .ToList();

        public async Task<PurchasedProduct> GetRepeatableTemporarytPurchaseByUserNameAsync(string userName, Guid productId, bool justRanks) =>
            (await GetAllActivePurchasesByUserNameAsync(userName, justRanks))
                .Where(purchasedProduct =>
                purchasedProduct.ProductId == productId
                && purchasedProduct.IsRepeatable == true
                && purchasedProduct.IsPermanent == false
                && purchasedProduct.PurchaseDate.AddDays(
                Math.Abs(purchasedProduct.ValidityPeriodInMonths * 30)) >= DateTime.Now)
           .FirstOrDefault();

        public async Task<ActualValueOfOneKredit> GetActualValueOfOneKreditAsync() =>
            await _dbContext.ActualValueOfOneKredit.FirstOrDefaultAsync();

        public async Task<ActualValueOfOneKredit> SetActualValueOfOneKreditAsync(decimal value)
        {
            var existingValue = await _dbContext.ActualValueOfOneKredit
               .FirstOrDefaultAsync();
            decimal decimalValue = 1;
            try
            {
                decimalValue = Math.Abs(value);
            }
            catch (Exception)
            {
                return existingValue;
            }

            if (existingValue != null && existingValue.IsActive)
            {
                existingValue.Value = decimalValue;
                _dbContext.ActualValueOfOneKredit.Update(existingValue);
                await SaveChangesAsync();
            }

            return existingValue;
        }

        private async Task<IList<PurchasedProduct>> GetPurchases(bool justRanks)
        {
            if (justRanks)
            {
                return await _dbContext.PurchasedProducts
                .Include(purchasedProduct => purchasedProduct.Product)
                .Include(purchasedProduct => purchasedProduct.User)
                .ThenInclude(user => user.Role)
                .Where(purchasedProduct =>
                    purchasedProduct.Product.IsRank &&
                    purchasedProduct.IsActive)
                .OrderBy(purchasedProduct => purchasedProduct.IsOverwrittenByOtherRank)
                .ThenBy(purchasedProduct => purchasedProduct.IsExpirationVerified)
                .ThenByDescending(purchasedProduct => purchasedProduct.IsPermanent)
                .ThenByDescending(purchasedProduct => purchasedProduct.PurchaseDate)
                .ToListAsync();
            }

            return await _dbContext.PurchasedProducts
                .Include(purchasedProduct => purchasedProduct.Product)
                .Include(purchasedProduct => purchasedProduct.User)
                .ThenInclude(user => user.Role)
                .Where(purchasedProduct => purchasedProduct.IsActive)
                .OrderBy(purchasedProduct => purchasedProduct.IsOverwrittenByOtherRank)
                .ThenBy(purchasedProduct => purchasedProduct.IsExpirationVerified)
                .ThenByDescending(purchasedProduct => purchasedProduct.IsPermanent)
                .ThenByDescending(purchasedProduct => purchasedProduct.PurchaseDate)
                .ToListAsync();
        }

        public async Task<IList<PurchasedProduct>> GetAllPurchasesGroupByMonthAsync() =>
            await _dbContext.PurchasedProducts
                .Include(purchasedProduct => purchasedProduct.Product)
                .Where(purchasedProduct => purchasedProduct.IsActive)
                .OrderBy(x => new { x.PurchaseDate.Year, x.PurchaseDate.Month })
                .GroupBy(x => new { x.PurchaseDate.Year, x.PurchaseDate.Month })
                .SelectMany(purchase => purchase)
                .ToListAsync();

        public async override Task<IList<PurchasedProduct>> GetAllAsync() =>
            await _dbContext.PurchasedProducts
                .Where(entity => entity.IsActive)
                .Include(purchasedProduct => purchasedProduct.Product)
                .Include(purchasedProduct => purchasedProduct.User)
                .ToListAsync();

        public async Task<IList<PurchasedProduct>> GetPurchasesOfActualDayAsync() =>
            await _dbContext.PurchasedProducts
                .Where(entity => entity.IsActive &&
                entity.PurchaseDate.DayOfYear == DateTime.Now.DayOfYear)
                .Include(purchasedProduct => purchasedProduct.Product)
                .Include(purchasedProduct => purchasedProduct.User)
                .ToListAsync();

        public async Task<IList<PurchasedProduct>> GetPurchasesOfActualWeekAsync() =>
            await _dbContext.PurchasedProducts
                .Where(entity => entity.IsActive &&
                entity.PurchaseDate >= DateTime.Today.AddDays(-1 * (int)DateTime.Today.DayOfWeek))
                .Include(purchasedProduct => purchasedProduct.Product)
                .Include(purchasedProduct => purchasedProduct.User)
                .ToListAsync();
    }
}

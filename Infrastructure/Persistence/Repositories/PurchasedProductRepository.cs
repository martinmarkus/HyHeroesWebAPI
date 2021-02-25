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

        public async Task<IList<PurchasedProduct>> GetAllRankPurchasesByTypeAsync(bool rank) =>
            await _dbContext.PurchasedProducts
                .Include(purchasedProduct => purchasedProduct.PurchaseStates)
                .Include(purchasedProduct => purchasedProduct.Product)
                .ThenInclude(product => product.GameServer)
                .Include(purchasedProduct => purchasedProduct.User)
                .ThenInclude(user => user.Role)
                .Where(purchasedProduct => purchasedProduct.Product.IsRank == rank &&
                    purchasedProduct.IsActive)
                .OrderBy(purchasedProduct => purchasedProduct.IsOverwrittenByOtherRank)
                .ThenByDescending(purchasedProduct => purchasedProduct.IsPermanent)
                .ThenByDescending(purchasedProduct => purchasedProduct.LastPurchaseDate)
                .ToListAsync();

        public async override Task<PurchasedProduct> GetByIdAsync(Guid id) =>
            await _dbContext.PurchasedProducts
                .Include(purchasedProduct => purchasedProduct.PurchaseStates)
                .Include(purchasedProduct => purchasedProduct.Product)
                .ThenInclude(product => product.GameServer)
                .Include(purchasedProduct => purchasedProduct.User)
                .ThenInclude(user => user.Role)
                .Where(purchasedProduct => purchasedProduct.IsActive && purchasedProduct.Id == id)
                .OrderBy(purchasedProduct => purchasedProduct.IsOverwrittenByOtherRank)
                .ThenByDescending(purchasedProduct => purchasedProduct.IsPermanent)
                .ThenByDescending(purchasedProduct => purchasedProduct.LastPurchaseDate)
                .FirstOrDefaultAsync();

        public async Task<IList<PurchasedProduct>> GetAllVerifiedPurchasedProductsAsync(bool justRanks)
        {
            var runningServerIds = await _dbContext.GameServers
                .Where(server => server.IsActive && server.IsServerRunning)
                .Select(server => server.Id)
                .ToListAsync();

            return await _dbContext.PurchasedProducts
                .Include(purchasedProduct => purchasedProduct.PurchaseStates)
                .Include(purchasedProduct => purchasedProduct.Product)
                .ThenInclude(product => product.GameServer)
                .Include(purchasedProduct => purchasedProduct.User)
                .ThenInclude(user => user.Role)
                .Where(purchasedProduct =>
                    purchasedProduct.Product.IsRank == justRanks &&
                    purchasedProduct.IsActive &&
                    purchasedProduct.PurchaseStates
                        .Where(state => state.IsActive
                            && state.IsActivationVerified
                            && runningServerIds.Contains(state.GameServerId))
                           .ToList().Count == runningServerIds.Count)
                .OrderBy(purchasedProduct => purchasedProduct.IsOverwrittenByOtherRank)
                .ThenByDescending(purchasedProduct => purchasedProduct.IsPermanent)
                .ThenByDescending(purchasedProduct => purchasedProduct.LastPurchaseDate)
                .ToListAsync();
        }


        public async Task<IList<PurchasedProduct>> GetAllByIdsAsync(IList<Guid> ids, bool justRanks) =>
            await _dbContext.PurchasedProducts
                .Include(purchasedProduct => purchasedProduct.PurchaseStates)
                .Include(purchasedProduct => purchasedProduct.Product)
                .ThenInclude(product => product.GameServer)
                .Include(purchasedProduct => purchasedProduct.User)
                .ThenInclude(user => user.Role)
                .Where(purchasedProduct =>
                    purchasedProduct.Product.IsRank == justRanks &&
                    purchasedProduct.IsActive &&
                     ids.Contains(purchasedProduct.Id))
                .OrderBy(purchasedProduct => purchasedProduct.IsOverwrittenByOtherRank)
                .ThenByDescending(purchasedProduct => purchasedProduct.IsPermanent)
                .ThenByDescending(purchasedProduct => purchasedProduct.LastPurchaseDate)
                .ToListAsync();

        public async Task<IList<PurchasedProduct>> GetAllUnverifiedByIdsAsync(IList<Guid> ids, bool justRanks) =>
            await _dbContext.PurchasedProducts
                .Include(purchasedProduct => purchasedProduct.PurchaseStates)
                .Include(purchasedProduct => purchasedProduct.Product)
                .ThenInclude(product => product.GameServer)
                .Include(purchasedProduct => purchasedProduct.User)
                .ThenInclude(user => user.Role)
                .Where(purchasedProduct =>
                    purchasedProduct.Product.IsRank == justRanks &&
                    purchasedProduct.IsActive &&
                    purchasedProduct.PurchaseStates
                        .Where(state => state.IsActive
                        && !state.IsActivationVerified).Any())
                .OrderBy(purchasedProduct => purchasedProduct.IsOverwrittenByOtherRank)
                .ThenByDescending(purchasedProduct => purchasedProduct.IsPermanent)
                .ThenByDescending(purchasedProduct => purchasedProduct.LastPurchaseDate)
                .ToListAsync();


        public async Task UpdateAllAsync(IList<PurchasedProduct> purchasedProducts)
        {
            foreach (var purchasedProduct in purchasedProducts)
            {
                await UpdateAsync(purchasedProduct);
            }
        }

        public async Task<IList<PurchasedProduct>> GetUnverifiedPurchasedProductsByServerIdAsync(
            Guid serverId,
            bool justRanks) =>
            await _dbContext.PurchasedProducts
                .Include(purchasedProduct => purchasedProduct.PurchaseStates)
                .Include(purchasedProduct => purchasedProduct.Product)
                .ThenInclude(product => product.GameServer)
                .Include(purchasedProduct => purchasedProduct.User)
                .ThenInclude(user => user.Role)
                .Where(purchasedProduct =>
                    purchasedProduct.Product.IsRank == justRanks &&
                    purchasedProduct.IsActive &&
                    purchasedProduct.PurchaseStates
                    .Where(state => state.IsActive
                        && state.GameServerId == serverId
                        && !state.IsActivationVerified
                        && !state.IsExpirationVerified).Any())
                .OrderBy(purchasedProduct => purchasedProduct.IsOverwrittenByOtherRank)
                .ThenByDescending(purchasedProduct => purchasedProduct.IsPermanent)
                .ThenByDescending(purchasedProduct => purchasedProduct.LastPurchaseDate)
                .ToListAsync();

        public async Task<IList<PurchasedProduct>> GetUnverifiedExpiredPurchasedProductsAsync(
            Guid serverId, 
            bool justRanks) =>
            await _dbContext.PurchasedProducts
                .Include(purchasedProduct => purchasedProduct.PurchaseStates)
                .Include(purchasedProduct => purchasedProduct.Product)
                .ThenInclude(product => product.GameServer)
                .Include(purchasedProduct => purchasedProduct.User)
                .ThenInclude(user => user.Role)
                .Where(purchasedProduct =>
                    purchasedProduct.Product.IsRank == justRanks &&
                    purchasedProduct.IsActive &&
                    !purchasedProduct.IsPermanent && !purchasedProduct.IsOverwrittenByOtherRank
                    && purchasedProduct.LastPurchaseDate.AddDays(
                        Math.Abs(purchasedProduct.ValidityPeriodInMonths * 30)) < DateTime.Now
                        && purchasedProduct.PurchaseStates.Where(state => state.IsActive
                        && state.GameServerId == serverId
                        && !state.IsExpirationVerified).Any())
                .OrderBy(purchasedProduct => purchasedProduct.IsOverwrittenByOtherRank)
                .ThenByDescending(purchasedProduct => purchasedProduct.IsPermanent)
                   .ToListAsync();

        public async Task<IList<PurchasedProduct>> GetAllExpiredPurchasedProductsAsync(bool justRanks) =>
            await _dbContext.PurchasedProducts
                .Include(purchasedProduct => purchasedProduct.PurchaseStates)
                .Include(purchasedProduct => purchasedProduct.Product)
                .ThenInclude(product => product.GameServer)
                .Include(purchasedProduct => purchasedProduct.User)
                .ThenInclude(user => user.Role)
                .Where(purchasedProduct => purchasedProduct.Product.IsRank == justRanks && purchasedProduct.IsActive
                    && !purchasedProduct.IsPermanent
                    && purchasedProduct.LastPurchaseDate.AddDays(
                        Math.Abs(purchasedProduct.ValidityPeriodInMonths * 30)) < DateTime.Now)
                .OrderBy(purchasedProduct => purchasedProduct.IsOverwrittenByOtherRank)
                .ThenByDescending(purchasedProduct => purchasedProduct.IsPermanent)
                .ThenByDescending(purchasedProduct => purchasedProduct.LastPurchaseDate)
                .ToListAsync();

        public async Task<IList<PurchasedProduct>> GetAllActivePurchasesByUserNameAsync(string userName, bool justRanks) =>
            await _dbContext.PurchasedProducts
                .Include(purchasedProduct => purchasedProduct.PurchaseStates)
                .Include(purchasedProduct => purchasedProduct.Product)
                .ThenInclude(product => product.GameServer)
                .Include(purchasedProduct => purchasedProduct.User)
                .ThenInclude(user => user.Role)
                .Where(purchasedProduct =>
                    purchasedProduct.Product.IsRank == justRanks &&
                    purchasedProduct.IsActive &&
                    purchasedProduct.User.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase)
                        && ((purchasedProduct.LastPurchaseDate.AddDays(
                            Math.Abs(purchasedProduct.ValidityPeriodInMonths * 30)) >= DateTime.Now)
                            || purchasedProduct.IsPermanent))
                .OrderBy(purchasedProduct => purchasedProduct.IsOverwrittenByOtherRank)
                .ThenByDescending(purchasedProduct => purchasedProduct.IsPermanent)
                .ThenByDescending(purchasedProduct => purchasedProduct.LastPurchaseDate)
                .ToListAsync();

        public async Task<IList<PurchasedProduct>> GetAllByUserNameAsync(string userName, bool justRanks) =>
            await _dbContext.PurchasedProducts
                .Include(purchasedProduct => purchasedProduct.PurchaseStates)
                .Include(purchasedProduct => purchasedProduct.Product)
                .ThenInclude(product => product.GameServer)
                .Include(purchasedProduct => purchasedProduct.User)
                .ThenInclude(user => user.Role)
                .Where(purchasedProduct =>
                    purchasedProduct.Product.IsRank == justRanks &&
                    purchasedProduct.IsActive &&
                    purchasedProduct.User.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase))
                .OrderBy(purchasedProduct => purchasedProduct.IsOverwrittenByOtherRank)
                .ThenByDescending(purchasedProduct => purchasedProduct.IsPermanent)
                .ThenByDescending(purchasedProduct => purchasedProduct.LastPurchaseDate)
                .ToListAsync();

        public async Task<IList<PurchasedProduct>> GetAllByUserNameAsync(string userName) =>
            await _dbContext.PurchasedProducts
              .Include(purchasedProduct => purchasedProduct.PurchaseStates)
              .Include(purchasedProduct => purchasedProduct.Product)
              .ThenInclude(product => product.GameServer)
              .Include(purchasedProduct => purchasedProduct.User)
              .ThenInclude(user => user.Role)
              .Where(purchasedProduct =>
                  purchasedProduct.IsActive && 
                  purchasedProduct.User.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase))
              .OrderBy(purchasedProduct => purchasedProduct.IsOverwrittenByOtherRank)
              .ThenByDescending(purchasedProduct => purchasedProduct.Product.IsRank)
              .ThenByDescending(purchasedProduct => purchasedProduct.IsPermanent)
              .ThenByDescending(purchasedProduct => purchasedProduct.LastPurchaseDate)
              .ToListAsync();

        public async Task<IList<PurchasedProduct>> GetAllActivePurchasesByEmailAsync(string email, bool justRanks) =>
            await _dbContext.PurchasedProducts
                .Include(purchasedProduct => purchasedProduct.PurchaseStates)
                .Include(purchasedProduct => purchasedProduct.Product)
                .ThenInclude(product => product.GameServer)
                .Include(purchasedProduct => purchasedProduct.User)
                .ThenInclude(user => user.Role)
                .Where(purchasedProduct => purchasedProduct.Product.IsRank == justRanks &&
                    purchasedProduct.IsActive &&
                    purchasedProduct.User.Email.Equals(email, StringComparison.OrdinalIgnoreCase)
                        && ((purchasedProduct.LastPurchaseDate.AddDays(
                            Math.Abs(purchasedProduct.ValidityPeriodInMonths * 30)) >= DateTime.Now)
                            || purchasedProduct.IsPermanent))
                .OrderBy(purchasedProduct => purchasedProduct.IsOverwrittenByOtherRank)
                .ThenByDescending(purchasedProduct => purchasedProduct.IsPermanent)
                .ThenByDescending(purchasedProduct => purchasedProduct.LastPurchaseDate)
                .ToListAsync();

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
                    && purchasedProduct.LastPurchaseDate.AddDays(
                        Math.Abs(purchasedProduct.ValidityPeriodInMonths * 30)) >= DateTime.Now)
                .FirstOrDefault();

        public async Task<IList<PurchasedProduct>> GetLastPurchasesAsync(int purchaseCount) =>
            await _dbContext.PurchasedProducts
                .Include(purchasedProduct => purchasedProduct.PurchaseStates)
                .Include(purchasedProduct => purchasedProduct.Product)
                .ThenInclude(product => product.GameServer)
                .Include(purchasedProduct => purchasedProduct.User)
                .ThenInclude(user => user.Role)
                .Where(purchasedProduct => purchasedProduct.IsActive)
                .OrderBy(purchasedProduct => purchasedProduct.IsOverwrittenByOtherRank)
                .ThenByDescending(purchasedProduct => purchasedProduct.IsPermanent)
                .ThenByDescending(purchasedProduct => purchasedProduct.LastPurchaseDate)
                .OrderByDescending(purchase => purchase.LastPurchaseDate)
                .Take(purchaseCount)
                .ToListAsync();

        public async Task<IList<PurchasedProduct>> GetAllPurchasesGroupByMonthAsync() =>
            await _dbContext.PurchasedProducts
                .Include(purchasedProduct => purchasedProduct.Product)
                .ThenInclude(product => product.GameServer)
                .Where(purchasedProduct => purchasedProduct.IsActive)
                .OrderBy(x => new { x.LastPurchaseDate.Year, x.LastPurchaseDate.Month })
                .GroupBy(x => new { x.LastPurchaseDate.Year, x.LastPurchaseDate.Month })
                .SelectMany(purchase => purchase)
                .ToListAsync();

        public async override Task<IList<PurchasedProduct>> GetAllAsync() =>
            await _dbContext.PurchasedProducts
                .Include(purchasedProduct => purchasedProduct.Product)
                .Include(purchasedProduct => purchasedProduct.User)
                .Where(entity => entity.IsActive)
                .ToListAsync();

        public async Task<IList<PurchasedProduct>> GetPurchasesOfActualDayAsync() =>
            await _dbContext.PurchasedProducts
                .Include(purchasedProduct => purchasedProduct.Product)
                .ThenInclude(product => product.GameServer)
                .Include(purchasedProduct => purchasedProduct.User)
                .Where(entity => entity.IsActive &&
                    entity.LastPurchaseDate.DayOfYear == DateTime.Now.DayOfYear)
                .ToListAsync();

        public async Task<IList<PurchasedProduct>> GetPurchasesOfActualWeekAsync() =>
            await _dbContext.PurchasedProducts
                .Include(purchasedProduct => purchasedProduct.Product)
                .ThenInclude(product => product.GameServer)
                .Include(purchasedProduct => purchasedProduct.User)
                .Where(entity => entity.IsActive &&
                    entity.LastPurchaseDate >= DateTime.Today.AddDays(-1 * (int)DateTime.Today.DayOfWeek))
                .ToListAsync();

        public async Task<int> GetCountOfOverallPurchasesAsync() =>
            (await GetAllAsync()).Count;


        public async Task<IList<PurchasedProduct>> GetAllWithExceptingByUserNameAsync(
            Guid purchaseForExceptingId,
            string userName,
            bool justRanks) =>
            await _dbContext.PurchasedProducts
                .Include(purchasedProduct => purchasedProduct.PurchaseStates)
                .Include(purchasedProduct => purchasedProduct.Product)
                .ThenInclude(product => product.GameServer)
                .Include(purchasedProduct => purchasedProduct.User)
                .ThenInclude(user => user.Role)
                .Where(purchasedProduct =>
                    purchasedProduct.Product.IsRank == justRanks &&
                    purchasedProduct.IsActive &&
                    purchasedProduct.User.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase)
                        && purchasedProduct.Id != purchaseForExceptingId)
                .OrderBy(purchasedProduct => purchasedProduct.IsOverwrittenByOtherRank)
                .ThenByDescending(purchasedProduct => purchasedProduct.IsPermanent)
                .ThenByDescending(purchasedProduct => purchasedProduct.LastPurchaseDate)
                .ToListAsync();
    }
}

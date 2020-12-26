using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        [Obsolete]
        public async Task<IList<PurchasedProduct>> GetAllUnverifiedPurchasedProductsAsync(bool justRanks) => 
            (await GetPurchases(justRanks))
                //.Where(purchasedProduct => !purchasedProduct.IsVerified)
                .ToList();

        public async Task<IList<PurchasedProduct>> GetAllVerifiedPurchasedProductsAsync(bool justRanks)
        {
            var runningServerIds = await _dbContext.GameServers
                .Where(server => server.IsActive && server.IsServerRunning)
                .Select(server => server.Id)
                .ToListAsync();

            return (await GetPurchases(justRanks))
                .Where(purchase =>
                    purchase.IsActive
                    && purchase.PurchaseStates
                    .Where(state => state.IsActive
                        && state.IsActivationVerified
                        && runningServerIds.Contains(state.GameServerId))
                    .ToList().Count == runningServerIds.Count)
            .ToList();
        }


        public async Task<IList<PurchasedProduct>> GetAllByIdsAsync(IList<Guid> ids, bool justRanks) =>
           (await GetPurchases(justRanks))
                .Where(purchasedProduct => ids.Contains(purchasedProduct.Id))
                .ToList();

        public async Task<IList<PurchasedProduct>> GetAllUnverifiedByIdsAsync(IList<Guid> ids, bool justRanks) =>
            (await GetPurchases(justRanks))
                .Where(purchase =>
                    purchase.IsActive
                    && purchase.PurchaseStates
                    .Where(state => state.IsActive
                        && !state.IsActivationVerified).Any())
            .ToList();


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
            (await GetPurchases(justRanks))
                .Where(purchase =>
                    purchase.IsActive
                    && purchase.PurchaseStates
                    .Where(state => state.IsActive 
                        && state.GameServerId == serverId
                        && !state.IsActivationVerified
                        && !state.IsExpirationVerified).Any())
            .ToList();

        public async Task<IList<PurchasedProduct>> GetUnverifiedExpiredPurchasedProductsAsync(
            Guid serverId, 
            bool justRanks) =>
            (await GetPurchases(justRanks))
               .Where(purchasedProduct =>
                   !purchasedProduct.IsPermanent
                   && !purchasedProduct.IsOverwrittenByOtherRank
                   && purchasedProduct.LastPurchaseDate.AddDays(
                       Math.Abs(purchasedProduct.ValidityPeriodInMonths * 30)) < DateTime.Now
                   && purchasedProduct.PurchaseStates.Where(state => state.IsActive
                       && state.GameServerId == serverId
                       && !state.IsExpirationVerified).Any()
                   )
               .ToList();

        public async Task<IList<PurchasedProduct>> GetAllExpiredPurchasedProductsAsync(bool justRanks) =>
           (await GetPurchases(justRanks))
                .Where(purchasedProduct =>
                    !purchasedProduct.IsPermanent
                    //&& purchasedProduct.IsVerified
                    && purchasedProduct.LastPurchaseDate.AddDays(
                    Math.Abs(purchasedProduct.ValidityPeriodInMonths * 30)) < DateTime.Now)
                .ToList();

        public async Task<IList<PurchasedProduct>> GetAllActivePurchasesByUserNameAsync(string userName, bool justRanks) =>
        (await GetPurchases(justRanks))
                .Where(purchasedProduct =>
                    purchasedProduct.User.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase)
                    && ((purchasedProduct.LastPurchaseDate.AddDays(
                    Math.Abs(purchasedProduct.ValidityPeriodInMonths * 30)) >= DateTime.Now)
                    || purchasedProduct.IsPermanent))
                .ToList();

        public async Task<IList<PurchasedProduct>> GetAllByUserNameAsync(string userName, bool justRanks) =>
        (await GetPurchases(justRanks))
                .Where(purchasedProduct =>
                    purchasedProduct.User.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase))
                .ToList();

        public async Task<IList<PurchasedProduct>> GetAllActivePurchasesByEmailAsync(string email, bool justRanks) =>
           (await GetPurchases(justRanks))
               .Where(purchasedProduct =>
               purchasedProduct.User.Email.Equals(email, StringComparison.OrdinalIgnoreCase)
               && ((purchasedProduct.LastPurchaseDate.AddDays(
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
                && purchasedProduct.LastPurchaseDate.AddDays(
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
                .Include(purchasedProduct => purchasedProduct.PurchaseStates)
                .Include(purchasedProduct => purchasedProduct.Product)
                .Include(purchasedProduct => purchasedProduct.User)
                .ThenInclude(user => user.Role)
                //.Include(purchasedProduct => purchasedProduct.ServerActivation)
                .Where(purchasedProduct =>
                    purchasedProduct.Product.IsRank &&
                    purchasedProduct.IsActive)
                .OrderBy(purchasedProduct => purchasedProduct.IsOverwrittenByOtherRank)
                //.ThenBy(purchasedProduct => purchasedProduct.IsExpirationVerified)
                .ThenByDescending(purchasedProduct => purchasedProduct.IsPermanent)
                .ThenByDescending(purchasedProduct => purchasedProduct.LastPurchaseDate)
                .ToListAsync();
            }

            return await _dbContext.PurchasedProducts
                .Include(purchasedProduct => purchasedProduct.PurchaseStates)
                .Include(purchasedProduct => purchasedProduct.Product)
                .Include(purchasedProduct => purchasedProduct.User)
                .ThenInclude(user => user.Role)
                .Where(purchasedProduct => purchasedProduct.IsActive)
                .OrderBy(purchasedProduct => purchasedProduct.IsOverwrittenByOtherRank)
                //.ThenBy(purchasedProduct => purchasedProduct.IsExpirationVerified)
                .ThenByDescending(purchasedProduct => purchasedProduct.IsPermanent)
                .ThenByDescending(purchasedProduct => purchasedProduct.LastPurchaseDate)
                .ToListAsync();
        }

        public async Task<IList<PurchasedProduct>> GetAllPurchasesGroupByMonthAsync() =>
            await _dbContext.PurchasedProducts
                .Include(purchasedProduct => purchasedProduct.Product)
                .Where(purchasedProduct => purchasedProduct.IsActive)
                .OrderBy(x => new { x.LastPurchaseDate.Year, x.LastPurchaseDate.Month })
                .GroupBy(x => new { x.LastPurchaseDate.Year, x.LastPurchaseDate.Month })
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
                entity.LastPurchaseDate.DayOfYear == DateTime.Now.DayOfYear)
                .Include(purchasedProduct => purchasedProduct.Product)
                .Include(purchasedProduct => purchasedProduct.User)
                .ToListAsync();

        public async Task<IList<PurchasedProduct>> GetPurchasesOfActualWeekAsync() =>
            await _dbContext.PurchasedProducts
                .Where(entity => entity.IsActive &&
                entity.LastPurchaseDate >= DateTime.Today.AddDays(-1 * (int)DateTime.Today.DayOfWeek))
                .Include(purchasedProduct => purchasedProduct.Product)
                .Include(purchasedProduct => purchasedProduct.User)
                .ToListAsync();

        public async Task<int> GetCountOfOverallPurchasesAsync() =>
            (await GetAllAsync()).Count;

        [Obsolete]
        private IList<PurchasedProduct> GetFilteredPurchasesByServerName<T>(
           List<PurchasedProduct> purchases,
           IList<T> serverTypes,
           string serverName) where T : ServerTypeContainter
        {
            var filteredServerTypes = new List<ServerTypeContainter>();
            var resultPurchases = new List<PurchasedProduct>();

            foreach (var purchase in purchases)
            {
                foreach (var serverType in serverTypes)
                {
                    if (serverType.PurchasedProductId == purchase.Id)
                    {
                        filteredServerTypes.Add(serverType);
                    }
                }
            }

            foreach (var serverType in filteredServerTypes)
            {
                foreach (var serverTypeProp in serverType.GetType().GetProperties())
                {
                    try
                    {
                        if (serverTypeProp.Name.Equals(serverName, StringComparison.OrdinalIgnoreCase))
                        {
                            var propValue = (bool)serverTypeProp.GetValue(serverType);
                            if (!propValue)
                            {
                                resultPurchases.Add(serverType.PurchasedProduct);
                                break;
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }

            return resultPurchases;
        }

        [Obsolete]
        private IList<PurchasedProduct> GetFilteredPurchasesListByServerNameOnMissingSpecificExpirationValidation<T>(
           List<PurchasedProduct> purchases,
           IList<T> serverTypes,
           string serverName) where T : ServerTypeContainter
        {
            var filteredServerTypes = new List<ServerTypeContainter>();
            var resultPurchases = new List<PurchasedProduct>();

            foreach (var purchase in purchases)
            {
                foreach (var serverType in serverTypes)
                {
                    if (serverType.PurchasedProductId == purchase.Id)
                    {
                        filteredServerTypes.Add(serverType);
                    }
                }
            }

            foreach (var serverType in filteredServerTypes)
            {
                foreach (var serverTypeProp in serverType.GetType().GetProperties())
                {
                    try
                    {
                        if (serverTypeProp.Name.Equals(serverName, StringComparison.OrdinalIgnoreCase))
                        {
                            var propValue = (bool)serverTypeProp.GetValue(serverType);
                            if (!propValue)
                            {
                                resultPurchases.Add(serverType.PurchasedProduct);
                            }

                            break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }

            return resultPurchases;
        }

        public async Task<IList<PurchasedProduct>> GetAllWithExceptingByUserNameAsync(
            Guid purchaseForExceptingId,
            string userName,
            bool justRanks) =>
            (await GetPurchases(justRanks))
                    .Where(purchasedProduct =>
                        purchasedProduct.User.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase)
                        && purchasedProduct.Id != purchaseForExceptingId)
                    .ToList();
    }
}

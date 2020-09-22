using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.ApplicationCore.Enums;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class KreditPurchaseRepository : AsyncRepository<KreditPurchase>, IKreditPurchaseRepository
    {
        public KreditPurchaseRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IList<KreditPurchase>> GetAllBarionPurchasesesAsync() =>
            await _dbContext.KreditPurchases
                .Where(purchase => purchase.IsActive 
                && purchase.PaymentType == PaymentType.Barion)
                .ToListAsync();

        public async Task<IList<KreditPurchase>> GetAllEDSMSKreditPurchasesAsync() =>
            await _dbContext.KreditPurchases
                .Where(purchase => purchase.IsActive
                && purchase.PaymentType == PaymentType.EDSMS)
                .ToListAsync();

        public async Task<IList<KreditPurchase>> GetAllPayPalPurchasesAsync() =>
            await _dbContext.KreditPurchases
                .Where(purchase => purchase.IsActive
                && purchase.PaymentType == PaymentType.PayPal)
                .ToListAsync();
    }
}

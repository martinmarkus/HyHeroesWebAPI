using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.ApplicationCore.Enums;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class BarionTransactionRepository : AsyncRepository<BarionTransaction>, IBarionTransactionRepository
    {
        public BarionTransactionRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<BarionTransaction> GetByBarionPaymentIdAsync(Guid paymentId) =>
            await _dbContext.BarionTransactions
                .Include(transaction => transaction.User)
                .Include(transaction => transaction.BarionBillingAddress)
                .Where(transaction => transaction.IsActive
                    && transaction.PaymentId == paymentId
                    && transaction.IsFinished == false
                    && transaction.State == BarionTransactionState.Started)
                .FirstOrDefaultAsync();

    }
}

using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class BillingoBankAccountRepository : AsyncRepository<BillingoBankAccount>, IBillingoBankAccountRepository
    {
        public BillingoBankAccountRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<BillingoBankAccount> GetSellerBankAccountAsync() =>
            await _dbContext.BillingoBankAccounts
                .Where(account => account.IsActive)
                .FirstOrDefaultAsync();
    }
}

using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class FailedTransactionRepository : AsyncRepository<FailedTransaction>, IFailedTransactionRepository
    {
        public FailedTransactionRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }
    }
}

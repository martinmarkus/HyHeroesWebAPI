using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class BarionTransactionRepository : AsyncRepository<BarionTransaction>, IBarionTransactionRepository
    {
        public BarionTransactionRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }
    }
}

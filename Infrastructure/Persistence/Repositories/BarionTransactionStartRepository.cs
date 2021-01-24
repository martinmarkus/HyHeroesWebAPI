using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class BarionTransactionStartRepository : AsyncRepository<BarionTransactionStart>, IBarionTransactionStartRepository
    {
        public BarionTransactionStartRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }
    }
}

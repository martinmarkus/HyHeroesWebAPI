using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class BillingoProductRepository : AsyncRepository<BillingoProduct>, IBillingoProductRepository
    {
        public BillingoProductRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }
    }
}

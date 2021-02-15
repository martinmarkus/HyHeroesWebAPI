using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class BillingoClientRepository : AsyncRepository<BillingoClient>, IBillingoClientRepository
    {
        public BillingoClientRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }
    }
}

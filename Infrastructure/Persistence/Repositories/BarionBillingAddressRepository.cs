using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class BarionBillingAddressRepository : AsyncRepository<BarionBillingAddress>, IBarionBillingAddressRepository
    {
        public BarionBillingAddressRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }
    }
}

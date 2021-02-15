using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class BillingoBillingAddressRepository
        : AsyncRepository<BillingoBillingAddress>, IBillingoBillingAddressRepository
    {
        public BillingoBillingAddressRepository(HyHeroesDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}

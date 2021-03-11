using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class PayPalBillingAddressRepository : AsyncRepository<PayPalBillingAddress>, IPayPalBillingAddressRepository
    {
        public PayPalBillingAddressRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }
    }
}

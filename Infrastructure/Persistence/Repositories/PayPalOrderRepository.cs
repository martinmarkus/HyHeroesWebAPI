using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class PayPalOrderRepository : AsyncRepository<PayPalOrder>, IPayPalOrderRepository
    {
        public PayPalOrderRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }
    }
}

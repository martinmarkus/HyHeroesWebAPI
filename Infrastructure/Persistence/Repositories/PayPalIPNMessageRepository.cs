using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class PayPalIPNMessageRepository : AsyncRepository<PayPalIPNMessage>, IPayPalIPNMessageRepository
    {
        public PayPalIPNMessageRepository(HyHeroesDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}

using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class PayPalTransactionRequestRepository : AsyncRepository<PayPalTransactionRequest>, IPayPalTransactionRequestRepository
    {
        public PayPalTransactionRequestRepository(HyHeroesDbContext dbContext) 
            : base(dbContext)
        {
        }
    }
}

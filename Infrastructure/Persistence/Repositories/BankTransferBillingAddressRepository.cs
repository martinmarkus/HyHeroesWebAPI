using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class BankTransferBillingAddressRepository : AsyncRepository<BankTransferBillingAddress>, IBankTransferBillingAddressRepository
    {
        public BankTransferBillingAddressRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }
    }
}

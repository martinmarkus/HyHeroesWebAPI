using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class BillingoPartnerRepository : AsyncRepository<BillingoPartner>, IBillingoPartnerRepository
    {
        public BillingoPartnerRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }
    }
}

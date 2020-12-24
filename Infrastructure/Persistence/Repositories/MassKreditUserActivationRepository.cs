using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class MassKreditUserActivationRepository : AsyncRepository<MassKreditUserActivation>, IMassKreditUserActivationRepository
    {
        public MassKreditUserActivationRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }
    }
}

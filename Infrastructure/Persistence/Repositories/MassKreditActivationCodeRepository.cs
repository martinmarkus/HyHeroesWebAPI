using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class MassKreditActivationCodeRepository : AsyncRepository<MassKreditActivationCode>, IMassKreditActivationCodeRepository
    {
        public MassKreditActivationCodeRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }
    }
}

using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class KreditGiftRepository : AsyncRepository<KreditGift>, IKreditGiftRepository
    {
        public KreditGiftRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }
    }
}

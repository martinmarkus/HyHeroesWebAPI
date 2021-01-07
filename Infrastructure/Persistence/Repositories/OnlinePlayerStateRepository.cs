using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class OnlinePlayerStateRepository : AsyncRepository<OnlinePlayerState>, IOnlinePlayerStateRepository
    {
        public OnlinePlayerStateRepository(HyHeroesDbContext context) : base(context)
        {

        }
    }
}

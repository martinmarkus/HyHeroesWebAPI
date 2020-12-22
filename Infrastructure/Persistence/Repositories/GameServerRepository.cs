using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class GameServerRepository : AsyncRepository<GameServer>, IGameServerRepository
    {
        public GameServerRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }
    }
}

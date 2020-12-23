using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class GameServerRepository : AsyncRepository<GameServer>, IGameServerRepository
    {
        public GameServerRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<int> GetCountOfRunningServersAsync() =>
            await _dbContext.GameServers
                .Where(server => server.IsActive && server.IsServerRunning)
                .CountAsync();
    }
}

using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Extensions;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class OnlinePlayerStateRepository : AsyncRepository<OnlinePlayerState>, IOnlinePlayerStateRepository
    {
        public OnlinePlayerStateRepository(HyHeroesDbContext context) : base(context)
        {
        }

        public async Task RemoveAllAsync()
        {
            _dbContext.OnlinePlayerStates.Clear();
            await _dbContext.SaveChangesAsync();
        }
    }
}

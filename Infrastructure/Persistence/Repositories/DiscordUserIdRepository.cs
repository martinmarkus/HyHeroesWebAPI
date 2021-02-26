using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using System;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class DiscordUserIdRepository : AsyncRepository<DiscordUserId>, IDiscordUserIdRepository
    {
        public DiscordUserIdRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<DiscordUserId> GetByUserIdAsync(Guid userId) =>
            await _dbContext.DiscordUserIds
                .Include(discordUserId => discordUserId.User)
                .Where(discordUserId => discordUserId.IsActive && discordUserId.UserId == userId)
                .FirstOrDefaultAsync();
    }
}

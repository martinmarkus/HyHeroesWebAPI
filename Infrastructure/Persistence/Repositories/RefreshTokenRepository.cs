using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class RefreshTokenRepository : AsyncRepository<RefreshToken>, IRefreshTokenRepository
    {
        public RefreshTokenRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<RefreshToken> GetByTokenValueAsync(string tokenValue) =>
            await _dbContext.RefreshTokens
                .Include(token => token.User)
                .Where(token => token.IsActive
                    && token.ExpirationDate > DateTime.Now
                    && token.TokenValue.Equals(tokenValue, StringComparison.OrdinalIgnoreCase))
                .FirstOrDefaultAsync();

        public async Task<RefreshToken> GetByUserIdAsync(Guid userId) =>
            await _dbContext.RefreshTokens
                .Include(token => token.User)
                .Where(token => token.IsActive
                    && token.UserId == userId)
                .FirstOrDefaultAsync();
    }
}

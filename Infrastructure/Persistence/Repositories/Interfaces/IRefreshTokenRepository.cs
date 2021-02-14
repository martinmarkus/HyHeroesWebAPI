using HyHeroesWebAPI.ApplicationCore.Entities;
using System;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface IRefreshTokenRepository : IAsyncRepository<RefreshToken>
    {
        Task<RefreshToken> GetByTokenValueAsync(string tokenValue);

        Task<RefreshToken> GetByUserIdAsync(Guid userId);
    }
}

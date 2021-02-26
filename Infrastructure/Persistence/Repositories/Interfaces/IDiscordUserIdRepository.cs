using HyHeroesWebAPI.ApplicationCore.Entities;
using System;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface IDiscordUserIdRepository : IAsyncRepository<DiscordUserId>
    {
        Task<DiscordUserId> GetByUserIdAsync(Guid id);
    }
}

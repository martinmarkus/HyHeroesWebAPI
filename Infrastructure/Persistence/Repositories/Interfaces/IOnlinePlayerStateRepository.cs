using HyHeroesWebAPI.ApplicationCore.Entities;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface IOnlinePlayerStateRepository : IAsyncRepository<OnlinePlayerState>
    {
        Task RemoveAllAsync();
    }
}

using HyHeroesWebAPI.ApplicationCore.DataObjects;
using HyHeroesWebAPI.ApplicationCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface IOnlinePlayerStateRepository : IAsyncRepository<OnlinePlayerState>
    {
        Task RemoveAllAsync();

        Task<IList<OnlinePlayerStateQueryResult>> GetLastDayDataAsync();
    }
}

using HyHeroesWebAPI.ApplicationCore.DataObjects;
using HyHeroesWebAPI.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface IGameServerRepository : IAsyncRepository<GameServer>
    {
        Task<int> GetCountOfRunningServersAsync();

        Task<IList<Guid>> GetAllRunningServerIdsAsync();
        
        Task<IList<PurchaseState>> GetAllByPurchasedRankIdAsync(Guid purchasedProductId);

        Task<IList<Guid>> GetAllIdsAsync();

        Task<IList<OnlinePlayerState>> GetGameServerPlayerStatesAsync();
    }
}

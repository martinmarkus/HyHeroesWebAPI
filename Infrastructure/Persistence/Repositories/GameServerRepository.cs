using HyHeroesWebAPI.ApplicationCore.DataObjects;
using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class GameServerRepository : AsyncRepository<GameServer>, IGameServerRepository
    {
        public GameServerRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IList<Guid>> GetAllIdsAsync() =>
            await _dbContext.GameServers
               .Where(server => server.IsActive)
               .Select(gameServer => gameServer.Id)
               .ToListAsync();

        public async Task<IList<Guid>> GetAllRunningServerIdsAsync() =>
             await _dbContext.GameServers
                .Where(server => server.IsActive && server.IsServerRunning)
                .Select(gameServer => gameServer.Id)
                .ToListAsync();

        public async Task<int> GetCountOfRunningServersAsync() =>
            await _dbContext.GameServers
                .Where(server => server.IsActive && server.IsServerRunning)
                .CountAsync();

        public async Task<IList<PurchaseState>> GetAllByPurchasedRankIdAsync(Guid purchasedProductId) =>
            await _dbContext.PurchaseStates
                .Include(state => state.PurchasedProduct)
                .ThenInclude(purchasedProduct => purchasedProduct.Product)
                .Where(state => state.IsActive
                    && state.PurchasedProductId == purchasedProductId
                    && state.PurchasedProduct.Product.IsRank)
                .Distinct()
                .ToListAsync();

        public async Task<IList<OnlinePlayerState>> GetGameServerPlayerStatesAsync() =>
            await _dbContext.GameServers
                .Include(server => server.OnlinePlayerStates)
                .Where(server => server.IsActive && server.IsServerRunning
                    && server.OnlinePlayerStates
                        .OrderByDescending(state => state.CreationDate)
                        .FirstOrDefault()
                        .CreationDate >= DateTime.Now.AddMinutes(-5)
                )
                .Select(server => new OnlinePlayerState()
                {
                    GameServerId = server.Id,
                    OnlinePlayerCount = server.OnlinePlayerStates
                        .OrderByDescending(state => state.CreationDate)
                        .FirstOrDefault()
                        .OnlinePlayerCount
                })
                .ToListAsync();
    }
}

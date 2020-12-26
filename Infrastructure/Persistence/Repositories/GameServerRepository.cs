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
                //.Select(state => state.GameServerId)
                .Distinct()
                .ToListAsync();
    }
}

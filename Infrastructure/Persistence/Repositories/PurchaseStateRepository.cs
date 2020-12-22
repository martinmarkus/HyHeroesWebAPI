using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class PurchaseStateRepository : AsyncRepository<PurchaseState>, IPurchaseStateRepository
    {
        public PurchaseStateRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IList<PurchaseState>> AddNewStateForEveryGameServersAsync(PurchaseState purchaseState)
        {
            var gameServers = await _dbContext.GameServers
                .Where(gameServer => gameServer.IsActive && gameServer.IsServerRunning)
                .ToListAsync();

            var addedStates = new List<PurchaseState>();

            foreach(var gameServer in gameServers)
            {
                purchaseState.GameServer = gameServer;
                purchaseState.GameServerId = gameServer.Id;

                await base.AddAsync(purchaseState);
                addedStates.Add(purchaseState);
            }

            return addedStates;
        }
    }
}

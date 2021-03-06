﻿using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
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
                var stateForAdd = new PurchaseState()
                {
                    GameServer = gameServer,
                    GameServerId = gameServer.Id,
                    PurchasedProduct = purchaseState.PurchasedProduct,
                    PurchasedProductId = purchaseState.PurchasedProductId
                };

                await base.AddAsync(stateForAdd);
                addedStates.Add(stateForAdd);
            }

            return addedStates;
        }

        public async Task<IList<PurchaseState>> GetByPurchasedProductIdAsync(Guid purchasedProductId) =>
            await _dbContext.PurchaseStates
                .Where(state => state.IsActive
                    && state.PurchasedProductId == purchasedProductId)
                .ToListAsync();
    }
}

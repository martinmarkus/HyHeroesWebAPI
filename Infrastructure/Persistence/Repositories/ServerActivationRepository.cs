using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class ServerActivationRepository : AsyncRepository<ServerActivation>, IServerActivationRepository
    {
        public ServerActivationRepository(HyHeroesDbContext hyHeroesDbContext)
            : base(hyHeroesDbContext)
        {

        }

        public async Task<ServerActivation> GetByPurchasedProductIdAsync(Guid id) =>
            await _dbContext.ServerActivations
            .Where(serverActivation => serverActivation.PurchasedProductId == id
                && serverActivation.IsActive)
            .FirstOrDefaultAsync();
    }
}

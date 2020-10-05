using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class ServerExpirationRepository : AsyncRepository<ServerExpiration>, IServerExpirationRepository
    {
        public ServerExpirationRepository(HyHeroesDbContext dbContext)
            : base(dbContext)
        {
        }

        public async Task<ServerExpiration> GetByPurchasedProductIdAsync(Guid id) =>
            await _dbContext.ServerExpirations
            .Where(expiration => expiration.PurchasedProductId == id && expiration.IsActive)
            .FirstOrDefaultAsync();
    }
}

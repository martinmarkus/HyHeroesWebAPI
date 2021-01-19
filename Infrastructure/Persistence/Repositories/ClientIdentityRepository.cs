using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class ClientIdentityRepository : AsyncRepository<ClientIdentity>, IClientIdentityRepository
    {
        public ClientIdentityRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<ClientIdentity> AddOrUpdateAsync(ClientIdentity identity)
        {
            var existingIdentity = await _dbContext.ClientIdentities
                .Where(anIdentity => anIdentity.IsActive
                    && identity.UserId == anIdentity.UserId)
                .FirstOrDefaultAsync();

            if (existingIdentity == null)
            {
                return await base.AddAsync(identity);
            }
            else
            {
                identity.Id = existingIdentity.Id;
                identity.CreationDate = existingIdentity.CreationDate;
                identity.RowVersion = existingIdentity.RowVersion;

                await base.UpdateAsync(identity);
                return identity;
            }
        }

        public async Task<ClientIdentity> GetIdentityByUserNameAsync(string userName) =>
            await _dbContext.ClientIdentities
                .Include(identity => identity.User)
                .Where(identity => identity.IsActive
                    && identity.User.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase))
                .FirstOrDefaultAsync();
    }
}

using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.DbContexts;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories
{
    public class RoleRepository : AsyncRepository<Role>, IRoleRepository
    {
        public RoleRepository(HyHeroesDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Role> GetDefaultRoleAsnyc() =>
            await _dbContext.Roles
                .Where(role => role.PermissionLevel == 1
                    && role.IsActive)
                .FirstOrDefaultAsync();

        public async Task<Role> GetRoleByNameAsync(string name) =>
            await _dbContext.Roles
                .Where(role => 
                    role.Name.ToLower().Equals(name.ToLower(), StringComparison.OrdinalIgnoreCase)
                    && role.IsActive)
                .FirstOrDefaultAsync();
    }
}

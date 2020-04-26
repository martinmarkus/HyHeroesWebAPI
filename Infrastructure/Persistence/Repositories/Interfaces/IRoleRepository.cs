using HyHeroesWebAPI.ApplicationCore.Entities;
using System;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface IRoleRepository : IAsyncRepository<Role>
    {
        Task<Role> GetDefaultRoleAsnyc();

        Task<Role> GetRoleByNameAsync(string name);
    }
}

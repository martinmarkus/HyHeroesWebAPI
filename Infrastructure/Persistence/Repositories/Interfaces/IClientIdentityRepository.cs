using HyHeroesWebAPI.ApplicationCore.Entities;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface IClientIdentityRepository : IAsyncRepository<ClientIdentity>
    {
        Task<ClientIdentity> AddOrUpdateAsync(ClientIdentity identity);
    }
}

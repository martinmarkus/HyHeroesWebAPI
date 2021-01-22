using HyHeroesWebAPI.ApplicationCore.Entities;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface IBlacklistedIPRepository : IAsyncRepository<BlacklistedIP>
    {
        Task UnbanIpAsync(string IP);
    }
}

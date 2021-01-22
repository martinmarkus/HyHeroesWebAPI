using HyHeroesWebAPI.ApplicationCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface IBlacklistedIPRepository : IAsyncRepository<BlacklistedIP>
    {
        Task UnbanIpAsync(string IP);

        Task<bool> CheckIfExistsByIPAsync(string IP);

        Task<IList<BlacklistedIP>> GetLastBannedIPsAsync(int banCount);

        Task<BlacklistedIP> GetByIPAsync(string IP);
    }
}

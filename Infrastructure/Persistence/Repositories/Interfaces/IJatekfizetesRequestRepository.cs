using HyHeroesWebAPI.ApplicationCore.Entities;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface IJatekfizetesRequestRepository : IAsyncRepository<JatekfizetesRequest>
    {
        Task<bool> IsClientIPOnCooldownAsync(string clientIP);
    }
}

using HyHeroesWebAPI.ApplicationCore.Entities;
using System;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface IServerExpirationRepository : IAsyncRepository<ServerExpiration>
    {
        Task<ServerExpiration> GetByPurchasedProductIdAsync(Guid id);
    }
}

using HyHeroesWebAPI.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface IServerActivationRepository : IAsyncRepository<ServerActivation>
    {
        Task<ServerActivation> GetByPurchasedProductIdAsync(Guid id);
    }
}

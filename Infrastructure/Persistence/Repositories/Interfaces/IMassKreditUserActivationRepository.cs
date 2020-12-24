using HyHeroesWebAPI.ApplicationCore.Entities;
using System;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface IMassKreditUserActivationRepository : IAsyncRepository<MassKreditUserActivation>
    {
        Task<MassKreditUserActivation> GetByUserNameAndMassKreditIdAsync(string userName, Guid id);
    }
}

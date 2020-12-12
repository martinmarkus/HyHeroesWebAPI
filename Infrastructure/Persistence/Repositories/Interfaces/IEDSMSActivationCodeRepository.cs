using HyHeroesWebAPI.ApplicationCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface IEDSMSActivationCodeRepository : IAsyncRepository<EDSMSActivationCode>
    {
        Task<IList<EDSMSActivationCode>> GetAllUnusedCodesAsync();
        Task<EDSMSActivationCode> GetUnusedCodeByCodeValueAsync(string code);
    }
}

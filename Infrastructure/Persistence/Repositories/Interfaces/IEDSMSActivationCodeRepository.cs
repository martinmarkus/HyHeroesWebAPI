using HyHeroesWebAPI.ApplicationCore.Entities;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface IEDSMSActivationCodeRepository : IAsyncRepository<EDSMSActivationCode>
    {
        Task<EDSMSActivationCode> GetUnusedCodeByCodeValueAsync(string code);
    }
}

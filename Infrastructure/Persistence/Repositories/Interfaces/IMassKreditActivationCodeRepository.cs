using HyHeroesWebAPI.ApplicationCore.Entities;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces
{
    public interface IMassKreditActivationCodeRepository : IAsyncRepository<MassKreditActivationCode>
    {
        Task<MassKreditActivationCode> GetByKreditCodeAsync(string kreditCode);
        
        Task<IList<MassKreditActivationCode>> GetAllActiveCodesAsync();
        
        Task RemoveByKreditCodeAsync(string code);
    }
}

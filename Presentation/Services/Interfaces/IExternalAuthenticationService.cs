using HyHeroesWebAPI.Presentation.DTOs;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IExternalAuthenticationService
    {
        Task ValidateExternalAuthenticationAsync(ValidateAuthenticationByExternalDTO authDTO, string IP);

        Task ValidateExternalAuthenticationRangeAsync(ValidateAuthenticationByExternalListDTO authListDTO, string IP);
    }
}

using HyHeroesWebAPI.Presentation.DTOs;
using System.Collections;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IMassKreditActivationService
    {
        Task ActivateMassKreditCodeAsync(
            MassKreditCodeActivationDTO massKreditCodeActivationDTO,
            string userName);

        Task<MassKreditCodeDTO> AddMassKreditCodeAsync(NewMassKreditCodeDTO newMassKreditCodeDTO);

        Task RemoveMassKreditCodeAsync(RemoveMassKreditCodeDTO removeMassKreditCodeDTO);
        
        Task<ActiveMassKreditCodesDTO> GetAllActiveMassKreditCodesAsync();
    }
}

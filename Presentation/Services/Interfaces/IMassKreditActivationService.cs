using HyHeroesWebAPI.Presentation.DTOs.NewsDTOs;
using HyHeroesWebAPI.Presentation.DTOs.UserDTOs;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IMassKreditActivationService
    {
        Task<int> ActivateMassKreditCodeAsync(
            MassKreditCodeActivationDTO massKreditCodeActivationDTO,
            string userName);

        Task<MassKreditCodeDTO> AddMassKreditCodeAsync(NewMassKreditCodeDTO newMassKreditCodeDTO);

        Task RemoveMassKreditCodeAsync(RemoveMassKreditCodeDTO removeMassKreditCodeDTO);
        
        Task<ActiveMassKreditCodesDTO> GetAllActiveMassKreditCodesAsync();
    }
}

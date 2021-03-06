using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs.UserDTOs;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.Mappers.Interfaces
{
    public interface IMassKreditCodeMapper
    {
        ActiveMassKreditCodesDTO MapToActiveMassKreditCodesDTO(IList<MassKreditActivationCode> codes);
        
        MassKreditCodeDTO MapToMassKreditCodeDTO(MassKreditActivationCode code);
    }
}

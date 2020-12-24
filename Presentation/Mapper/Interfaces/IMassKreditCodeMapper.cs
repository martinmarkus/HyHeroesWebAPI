using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.Mapper.Interfaces
{
    public interface IMassKreditCodeMapper
    {
        ActiveMassKreditCodesDTO MapToActiveMassKreditCodesDTO(IList<MassKreditActivationCode> codes);
        MassKreditCodeDTO MapToMassKreditCodeDTO(MassKreditActivationCode code);
    }
}

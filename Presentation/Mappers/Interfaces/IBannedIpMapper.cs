using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs.UserDTOs;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.Mappers.Interfaces
{
    public interface IBannedIpMapper
    {
        BannedIPListDTO MapToBannedIPListDTO(IList<BlacklistedIP> lists);
    }
}

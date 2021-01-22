using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.Mapper.Interfaces
{
    public interface IBannedIpMapper
    {
        BannedIPListDTO MapToBannedIPListDTO(IList<BlacklistedIP> lists);
    }
}

using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mapper.Interfaces;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.Mapper
{
    public class BannedIpMapper : IBannedIpMapper
    {
        public BannedIPListDTO MapToBannedIPListDTO(IList<BlacklistedIP> blacklistedIps)
        {
            var dto = new BannedIPListDTO();

            foreach (var ip in blacklistedIps)
            {
                dto.BannedIPDTOs.Add(new BannedIPDTO()
                {
                    BanDate = ip.BanDate,
                    IP = ip.IP
                });
            }

            return dto;
        }
    }
}

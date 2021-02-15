using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mappers.Interfaces;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.Mappers
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

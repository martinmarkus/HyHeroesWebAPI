using HyHeroesWebAPI.ApplicationCore.DataObjects;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mapper.Interfaces;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.Mapper
{
    public class OnlinePlayerCountMapper : IOnlinePlayerCountMapper
    {
        public AggregatedOnlinePlayerCountDTOList MapToAggregatedOnlinePlayerCountDTO(IList<OnlinePlayerStateQueryResult> onlinePlayerQueryResultList)
        {
            var dto = new AggregatedOnlinePlayerCountDTOList();

            foreach (var onlinePlayer in onlinePlayerQueryResultList)
            {
                dto.OnlinePlayerCountDTOs.Add(new AggregatedOnlinePlayerCountDTO()
                {
                    Hour = onlinePlayer.HourDate.ToString("yyyy. MM. dd. HH") + ":00",
                    PlayerCount = onlinePlayer.PlayerCount
                });
            }

            return dto;
        }
    }
}

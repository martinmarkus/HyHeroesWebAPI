using HyHeroesWebAPI.ApplicationCore.DataObjects;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mappers.Interfaces;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.Mappers
{
    public class OnlinePlayerCountMapper : IOnlinePlayerCountMapper
    {
        public AggregatedOnlinePlayerCountDTOList MapToAggregatedOnlinePlayerCountDTO(
            IList<OnlinePlayerStatQueryResult> onlinePlayerQueryResultList)
        {
            var dto = new AggregatedOnlinePlayerCountDTOList();

            foreach (var onlinePlayer in onlinePlayerQueryResultList)
            {
                dto.OnlinePlayers.Add(new AggregatedOnlinePlayerCountDTO()
                {
                    Date = onlinePlayer.CreationDate.ToString("yyyy. MM. dd. HH") + ":00",
                    PlayerCount = onlinePlayer.PlayerCount
                });
            }

            return dto;
        }
    }
}

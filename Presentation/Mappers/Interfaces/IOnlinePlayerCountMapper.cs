using HyHeroesWebAPI.ApplicationCore.DataObjects;
using HyHeroesWebAPI.Presentation.DTOs.StatisticDTOs;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.Mappers.Interfaces
{
    public interface IOnlinePlayerCountMapper
    {    
        AggregatedOnlinePlayerCountDTOList MapToAggregatedOnlinePlayerCountDTO(IList<OnlinePlayerStatQueryResult> lists);
    }
}

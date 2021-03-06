﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.DTOs.StatisticDTOs
{
    public class AggregatedOnlinePlayerCountDTOList
    {
        [JsonProperty("onlinePlayers")]
        public IList<AggregatedOnlinePlayerCountDTO> OnlinePlayers { get; set; } = new List<AggregatedOnlinePlayerCountDTO>();
    }
}

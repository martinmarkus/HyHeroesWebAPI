using Newtonsoft.Json;
using System;

namespace HyHeroesWebAPI.Presentation.DTOs.StatisticDTOs
{
    public class AggregatedOnlinePlayerCountDTO
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("playerCount")]
        public int PlayerCount { get; set; }
    }
}

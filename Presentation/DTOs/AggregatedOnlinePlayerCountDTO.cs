using Newtonsoft.Json;
using System;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class AggregatedOnlinePlayerCountDTO
    {
        [JsonProperty("date")]
        public string Hour { get; set; }

        [JsonProperty("playerCount")]
        public int PlayerCount { get; set; }
    }
}

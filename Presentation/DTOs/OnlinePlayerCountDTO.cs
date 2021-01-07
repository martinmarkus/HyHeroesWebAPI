using Newtonsoft.Json;
using System;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class OnlinePlayerCountDTO
    {
        [JsonProperty("dateTime")]
        public DateTime DateTime { get; set; }

        [JsonProperty("playerCount")]
        public int PlayerCount { get; set; }
    }
}

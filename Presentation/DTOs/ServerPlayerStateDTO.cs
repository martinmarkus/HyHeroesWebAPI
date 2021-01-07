using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class ServerPlayerStateDTO
    {
        [Required]
        [JsonProperty("gameServerId")]
        public Guid GameServerId { get; set; }

        [Required]
        [JsonProperty("playerCount")]
        public int PlayerCount { get; set; }
    }
}

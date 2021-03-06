using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs.ServerIntegrationDTOs
{
    public class GameServerDTO
    {
        [Required]
        [JsonProperty("serverName")]
        public string ServerName { get; set; }

        [Required]
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [Required]
        [JsonProperty("isServerRunning")]
        public bool IsServerRunning { get; set; }
    }
}

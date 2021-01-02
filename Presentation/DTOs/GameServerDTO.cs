using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.DTOs
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

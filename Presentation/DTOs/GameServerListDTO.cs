using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class GameServerListDTO
    {
        [Required]
        [JsonProperty("gameServers")]
        public IList<GameServerDTO> GameServers { get; set; } = new List<GameServerDTO>();
    }
}

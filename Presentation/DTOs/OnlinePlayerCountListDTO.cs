using Newtonsoft.Json;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class OnlinePlayerCountListDTO
    {
        [JsonProperty("onlinePlayerCountDTOs")]
        public IList<OnlinePlayerCountDTO> OnlinePlayerCountDTOs { get; set; } = new List<OnlinePlayerCountDTO>();
    }
}

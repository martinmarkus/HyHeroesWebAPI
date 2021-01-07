using Newtonsoft.Json;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.DTOs.StatisticDTOs
{
    public class TopProductStatsListDTO
    {
        [JsonProperty("topProductStatsDTOs")]
        public IList<TopProductStatsDTO> TopProductStatsDTOs { get; set; } = new List<TopProductStatsDTO>();
    }
}

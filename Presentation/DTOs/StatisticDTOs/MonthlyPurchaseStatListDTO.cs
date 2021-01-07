using HyHeroesWebAPI.Presentation.DTOs.StatisticDTOs;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.DTOs.StatisticDTOs
{
    public class MonthlyPurchaseStatListDTO
    {
        [JsonProperty("monthlyPurchaseStats")]
        public IList<MonthlyPurchaseStatDTO> MonthlyPurchaseStats { get; set; }
    }
}

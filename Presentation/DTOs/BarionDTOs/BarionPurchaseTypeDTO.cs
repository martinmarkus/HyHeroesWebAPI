﻿using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.BarionDTOs
{
    public class BarionPurchaseTypeDTO
    {
        [JsonProperty("grossValue")]
        public int GrossValue { get; set; }

        [JsonProperty("kreditValue")]
        public int KreditValue { get; set; }
    }
}

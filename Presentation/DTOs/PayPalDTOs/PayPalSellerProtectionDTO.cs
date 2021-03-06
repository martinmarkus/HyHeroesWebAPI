using System.Collections.Generic;
using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.PayPalDTOs
{
    public class PayPalSellerProtectionDTO
    {
        [JsonProperty("dispute_categories")]
        public List<string> DisputeCategories { get; set; }

        [JsonProperty("status")]
        public string PayPalStatus { get; set; }
    }
}

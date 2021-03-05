using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HyHeroesWebAPI.ApplicationCore.Enums;
using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.PayPalDTOs
{
    public class PayPalSellerProtectionDTO
    {
        [JsonProperty("dispute_categories")]
        public List<string> DisputeCategories { get; set; }
        [JsonProperty("status")]
        public PayPalStatus PayPalStatus { get; set; }
    }
}

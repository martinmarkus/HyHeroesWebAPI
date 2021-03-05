using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HyHeroesWebAPI.Presentation.DTOs.PayPalDTOs;
using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.PayPalOrderDTOs
{
    public class PayPalPurchaseUnitDTO
    {
        [JsonProperty("amount")]
        public PayPalAmountDTO Amount { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}

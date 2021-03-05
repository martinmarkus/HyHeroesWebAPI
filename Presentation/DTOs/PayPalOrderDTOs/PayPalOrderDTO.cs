using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HyHeroesWebAPI.Presentation.DTOs.PayPalDTOs;
using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.PayPalOrderDTOs
{
    public class PayPalOrderDTO
    {
        [JsonProperty("intent")]
        public String Intent { get; set; }
        [JsonProperty("purchase_units")]
        public List<PayPalPurchaseUnitDTO> PurchaseUnits { get; set; }
    }
}

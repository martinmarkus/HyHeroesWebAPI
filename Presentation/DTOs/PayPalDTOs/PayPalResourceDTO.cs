using System.Collections.Generic;
using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.PayPalDTOs
{
    public class PayPalResourceDTO
    {
        [JsonProperty("update_time")]
        public string UpdateTime { get; set; }

        [JsonProperty("create_time")]
        public string CreateTime { get; set; }

        [JsonProperty("links")]
        public List<PayPalLinkDTO> PayPalLinks { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string PayPalPaymentStatus { get; set; }

        [JsonProperty("intent")]
        public string Intent { get; set; }

        [JsonProperty("purchase_units")]
        public List<PayPalPurchaseUnitDTO> PurchaseUnits { get; set; }

        [JsonProperty("payer")]
        public PayPalPayerDTO Payer { get; set; }
    }
}

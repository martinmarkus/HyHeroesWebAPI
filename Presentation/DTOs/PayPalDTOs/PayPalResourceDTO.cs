using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HyHeroesWebAPI.ApplicationCore.Enums;
using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.PayPalDTOs
{
    public class PayPalResourceDTO
    {
        [JsonProperty("amount")]
        public PayPalAmountDTO Amount { get; set; }
        [JsonProperty("seller_protection")]
        public PayPalSellerProtectionDTO PayPalSellerProtection { get; set; }
        [JsonProperty("update_time")]
        public string UpdateTime { get; set; }
        [JsonProperty("create_time")]
        public string CreateTime { get; set; }
        [JsonProperty("final_capture")]
        public bool FinalCapture { get; set; }
        [JsonProperty("seller_receivable_breakdown")]
        public PayPalSellerReceivableBreakdownDTO PayPalSellerReceivableBreakdown { get; set; }
        [JsonProperty("links")]
        public List<PayPalLinkDTO> PayPalLinks { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("status")]
        public PayPalPaymentStatus PayPalPaymentStatus { get; set; }
    }
}

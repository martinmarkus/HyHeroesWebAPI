using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.ApplicationCore.Enums;
using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.PayPalOrderDTOs
{
    public class PayPalOrderResponseDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("payPalStatus")]
        public PayPalPaymentStatus PayPalStatus { get; set; }
        [JsonProperty("links")]
        public List<PayPalLink> Links { get; set; }
    }
}

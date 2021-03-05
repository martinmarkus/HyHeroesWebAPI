using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using HyHeroesWebAPI.ApplicationCore.Enums;
using Newtonsoft.Json;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    [Table("paypalorders")]
    public class PayPalOrder : BaseEntity
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("status")]
        public PayPalPaymentStatus Status { get; set; }
        [JsonProperty("links")]
        public List<PayPalLink> Links { get; set; }
    }
}

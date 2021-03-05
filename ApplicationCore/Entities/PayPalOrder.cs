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
        public string OrderId { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("links")]
        public List<PayPalLink> PayPalLinks { get; set; }
        [JsonIgnore]
        public Guid UserId { get; set; }
        [JsonIgnore]
        public User User { get; set; }
    }
}

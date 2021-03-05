using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    [Table("paypalorders")]
    public class PayPalOrder : BaseEntity
    {
        [JsonProperty("id")]
        [Required]
        public string OrderId { get; set; }

        [JsonProperty("status")]
        [Required]
        public string Status { get; set; }

        [JsonProperty("links")]
        public ICollection<PayPalLink> PayPalLinks { get; set; }

        [JsonIgnore]
        public Guid UserId { get; set; }

        [JsonIgnore]
        public virtual User User { get; set; }
    }
}

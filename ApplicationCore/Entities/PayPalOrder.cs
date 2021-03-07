using System;
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

        [JsonIgnore]
        public Guid UserId { get; set; }

        [JsonIgnore]
        public virtual User User { get; set; }
    }
}

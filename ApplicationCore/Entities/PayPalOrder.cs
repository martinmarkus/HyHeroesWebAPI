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
        public string BillingEmail { get; set; }

        [JsonIgnore]
        public string BillingName { get; set; }

        [JsonIgnore]
        public bool IsFinished { get; set; } = false;

        [JsonIgnore]
        public string TaxNumber { get; set; }

        [JsonIgnore]
        public int KreditAmount  { get; set; }

        [JsonIgnore]
        public int CurrencyValue { get; set; }

        [JsonIgnore]
        public Guid UserId { get; set; }

        [JsonIgnore]
        public virtual User User { get; set; }

        [JsonIgnore]
        public virtual PayPalBillingAddress PayPalBillingAddress { get; set; }
    }
}

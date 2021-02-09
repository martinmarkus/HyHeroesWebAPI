using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class BarionPaymentTransactionDTO
    {
        [Required]
        [JsonProperty("kreditAmount")]
        public double KreditAmount { get; set; }

        [Required]
        [JsonProperty("billingName")]
        public string BillingName { get; set; }

        [Required]
        [EmailAddress]
        [JsonProperty("billingEmail")]
        public string BillingEmail { get; set; }

        [RegularExpression(@"^(\d{7})(\d)\-([1-5])\-(0[2-9]|[13][0-9]|2[02-9]|4[0-4]|51)$")]
        [JsonProperty("taxNumber")]
        public string TaxNumber { get; set; }

        [Required]
        [JsonProperty("barionBillingAddressDTO")]
        public BarionBillingAddressDTO BarionBillingAddressDTO { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }
    }
}

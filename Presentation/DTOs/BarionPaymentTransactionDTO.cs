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
        [EmailAddress]
        [JsonProperty("payeeEmail")]
        public string PayeeEmail { get; set; }

        [Required]
        [JsonProperty("billingName")]
        public string BillingName { get; set; }

        [Required]
        [JsonProperty("barionBillingAddressDTO")]
        public BarionBillingAddressDTO BarionBillingAddressDTO { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }
    }
}

using HyHeroesWebAPI.Presentation.DTOs.PayPalDTOs;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class PayPalTransactionDTO
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

        [RegularExpression(@"[0-9]{8}-[0-9]{1}-[0-9]{2}")]
        [JsonProperty("taxNumber")]
        public string TaxNumber { get; set; }

        [Required]
        [JsonProperty("payPalBillingAddress")]
        public PayPalBillingAddressDTO PayPalBillingAddress { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }
    }
}

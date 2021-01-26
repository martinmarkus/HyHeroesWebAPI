using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class BarionPaymentTransactionDTO
    {
        [Required]
        [JsonProperty("userName")]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        [JsonProperty("payeeEmail")]
        public string PayeeEmail { get; set; }

        [Required]
        [JsonProperty("locale")]
        public string Locale { get; set; }

        [Required]
        [JsonProperty("currencyType")]
        public string CurrencyType { get; set; }

        [Required]
        [JsonProperty("barionBillingAddressDTO")]
        public BarionBillingAddressDTO BarionBillingAddressDTO { get; set; }

        [Required]
        [JsonProperty("kreditAmount")]
        public double KreditAmount { get; set; }


        [JsonProperty("comment")]
        public string Comment { get; set; }
    }
}

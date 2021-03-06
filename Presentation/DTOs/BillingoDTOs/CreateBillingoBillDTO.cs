using BarionClientLibrary.Operations.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.DTOs.BillingoDTOs
{
    public class CreateBillingoBillDTO
    {
        [Required]
        [JsonProperty("userName")]
        [RegularExpression(@"^[a-zA-Z0-9_]{3,20}$")]
        public string UserName { get; set; }

        [Required]
        [JsonProperty("kreditValue")]
        public int KreditValue { get; set; }

        [Required]
        [JsonProperty("currencyValue")]
        public int CurrencyValue { get; set; }

        [Required]
        [JsonProperty("paymentType")]
        public string PaymentType { get; set; }

        [Required]
        [JsonProperty("taxnumber")]
        public string Taxnumber { get; set; }

        [Required]
        [JsonProperty("clientEmail")]
        public string ClientEmail { get; set; }

        [Required]
        [JsonProperty("clientName")]
        public string ClientName { get; set; }

        [Required]
        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [Required]
        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

        [Required]
        [JsonProperty("city")]
        public string City { get; set; }

        [Required]
        [JsonProperty("address")]
        public string Address { get; set; }

        [Required]
        [JsonProperty("comment")]
        public string Comment { get; set; }
    }
}

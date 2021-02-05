﻿using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class BankTransferPurchaseDTO
    {
        [Required]
        [JsonProperty("kreditAmount")]
        public int KreditAmount { get; set; }

        [Required]
        [JsonProperty("billingName")]
        public string BillingName { get; set; }

        [Required]
        [JsonProperty("billingEmail")]
        public string BillingEmail { get; set; }

        [JsonProperty("taxNumber")]
        public string TaxNumber { get; set; }

        [Required]
        [JsonProperty("billingCity")]
        public string BillingCity { get; set; }

        [Required]
        [JsonProperty("billingCountry")]
        public string BillingCountry { get; set; }

        [Required]
        [JsonProperty("billingZip")]
        public string BillingZip { get; set; }

        [Required]
        [JsonProperty("billingStreet")]
        public string BillingStreet { get; set; }
    }
}
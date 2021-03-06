﻿using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs.BarionDTOs
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

        [RegularExpression(@"[0-9]{8}-[0-9]{1}-[0-9]{2}")]
        [JsonProperty("taxNumber")]
        public string TaxNumber { get; set; }

        [Required]
        [JsonProperty("barionBillingAddressDTO")]
        public BarionBillingAddressDTO BarionBillingAddressDTO { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }
    }
}

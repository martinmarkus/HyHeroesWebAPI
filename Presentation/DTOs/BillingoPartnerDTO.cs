using HyHeroesWebAPI.ApplicationCore.Entities;
using Newtonsoft.Json;
using System;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class BillingoPartnerDTO
    {
        [JsonProperty("id")]
        public string BillingoPartnerId { get; set; }

        [JsonProperty("name")]
        public string PartnerName { get; set; }

        [JsonProperty("emails")]
        public string[] Emails { get; set; }

        [JsonProperty("taxcode")]
        public string Taxcode { get; set; }

        [JsonProperty("iban")]
        public string Iban { get; set; }

        [JsonProperty("swift")]
        public string Swift { get; set; }

        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("general_ledger_number")]
        public string GeneralLedgerNumber { get; set; }

        [JsonProperty("tax_type")]
        public string TaxType { get; set; }

        [JsonIgnore]
        public Guid BillingoBillingAddressId { get; set; }

        [JsonProperty("address")]
        public virtual BillingoBillingAddress BillingoBillingAddress { get; set; }

        [JsonIgnore]
        public Guid UserId { get; set; }
    }
}

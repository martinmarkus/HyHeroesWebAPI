using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    [Table("billingopartners")]
    public class BillingoPartner : BaseEntity
    {
        [JsonProperty("id")]
        public string BillingoPartnerId { get; set; }

        [JsonProperty("name")]
        public string PartnerName { get; set; }

        [JsonProperty("email ")]
        public string Email { get; set; }

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

        [JsonIgnore]
        public virtual BillingoBillingAddress BillingoBillingAddress { get; set; }

        [JsonIgnore]
        public Guid UserId { get; set; }

        [JsonIgnore]
        public virtual User User { get; set; }

    }
}

using HyHeroesWebAPI.ApplicationCore.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class BillingoDocument : BaseEntity
    {
        [JsonProperty("id")]
        public long BillingoDocumentId { get; set; }

        [JsonProperty("vendor_id")]
        public string VendorId { get; set; }

        [JsonProperty("partner_id")]
        public long PartnerId { get; set; }

        [JsonProperty("block_id")]
        public long BlockId { get; set; }

        [JsonProperty("bank_account_id")]
        public long BankAccountId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("fulfillment_date")]
        public DateTime FulfillmentDate { get; set; }

        [JsonProperty("due_date")]
        public DateTime DueDate { get; set; }

        // INFO: Payment method (payment_method field)
        [JsonProperty("payment_method")]
        public PaymentType PaymentType { get; set; }

        [JsonProperty("conversion_rate")]
        public int ConversionRate { get; set; }

        [JsonProperty("electronic")]
        public bool Electronic { get; set; }

        [JsonProperty("paid")]
        public bool Paid { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonIgnore]
        public virtual IList<BillingoProduct> BillingoProducts { get; set; }

        [JsonIgnore]
        public Guid BillingoDocumentSettingsId { get; set; }

        [JsonIgnore]
        public virtual BillingoDocumentSettings BillingoDocumentSettings { get; set; }

        [JsonIgnore]
        public Guid BillingoBankAccountId { get; set; }

        [JsonIgnore]
        public virtual BillingoBankAccount BillingoBankAccount { get; set; }
    }
}

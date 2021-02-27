using HyHeroesWebAPI.ApplicationCore.DataObjects;
using HyHeroesWebAPI.ApplicationCore.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    [Table("billingodocuments")]
    public class BillingoDocument : BaseEntity
    {
        [JsonProperty("id")]
        public long BillingoDocumentId { get; set; }

        //[JsonProperty("vendor_id")]
        //public string VendorId { get; set; } = Guid.NewGuid().ToString();

        [JsonProperty("partner_id")]
        public long PartnerId { get; set; }

        [JsonProperty("block_id")]
        public long BlockId { get; set; }

        [JsonProperty("bank_account_id")]
        public long BankAccountId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; } = "advance";

        [JsonProperty("fulfillment_date")]
        public string FulfillmentDate { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        // INFO: Payment method (payment_method field)
        [JsonProperty("payment_method")]
        public string PaymentType { get; set; }

        [JsonProperty("conversion_rate")]
        public int ConversionRate { get; set; } = 1;

        [JsonProperty("electronic")]
        public bool Electronic { get; set; }

        [JsonProperty("paid")]
        public bool Paid { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("items")]
        public virtual IList<BillingoProduct> BillingoProducts { get; set; }

        [JsonIgnore]
        public Guid BillingoBankAccountId { get; set; }

        [JsonIgnore]
        public virtual BillingoBankAccount BillingoBankAccount { get; set; }
    }
}

using Newtonsoft.Json;
using System;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class BillingoProduct : BaseEntity
    {
        [JsonProperty("id")]
        public long BillingoProductId { get; set; }

        [JsonProperty("name")]
        public string ProductName { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("vat")]
        public string Vat { get; set; }

        [JsonProperty("net_unit_price")]
        public int NetUnitPrice { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("general_ledger_number")]
        public string GeneralLedgerNumber { get; set; }

        [JsonProperty("general_ledger_taxcode")]
        public string GeneralLedgerTaxcode { get; set; }

        [JsonProperty("entitlement")]
        public string Entitlement { get; set; }

        [JsonIgnore]
        public Guid BillingoDocumentId { get; set; }

        [JsonIgnore]
        public virtual BillingoDocument BillingoDocument { get; set; }
    }
}

using Newtonsoft.Json;
using System;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class BillingoDocumentSettings : BaseEntity
    {
        [JsonProperty("mediated_service")]
        public bool MediatedService { get; set; }

        [JsonProperty("without_financial_fulfillment")]
        public bool WithoutFinancialFulfillment { get; set; }

        [JsonProperty("online_payment")]
        public string OnlinePayment { get; set; }

        [JsonProperty("round")]
        public string Round { get; set; }

        [JsonProperty("order_number")]
        public string OrderNumber { get; set; }

        [JsonProperty("place_id")]
        public long PlaceId { get; set; }

        [JsonIgnore]
        public virtual BillingoDocument BillingoDocument { get; set; }
    }
}

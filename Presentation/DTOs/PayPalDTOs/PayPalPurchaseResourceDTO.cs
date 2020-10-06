using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.PayPalDTOs
{
    public class PayPalPurchaseResourceDTO 
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("create_time")]
        public string CreateTime { get; set; }

        [JsonProperty("update_time")]
        public string UpdateTime { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("amount")]
        public PayPalPurchaseAmountDTO Amount { get; set; }

        [JsonProperty("parent_payment")]
        public string ParentPayment { get; set; }

        [JsonProperty("valid_until")]
        public string ValidUntil { get; set; }

        [JsonProperty("links")]
        public PayPalPurchaseLinkDTO[] Links { get; set; }
    }
}

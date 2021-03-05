using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.PayPalDTOs
{
    public class PayPalPurchaseUnitDTO
    {
        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }
        [JsonProperty("amount")]
        public PayPalAmountDTO Amount { get; set; }
        [JsonProperty("payee")]
        public PayPalPayeeDTO Payee { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("shipping")]
        public PayPalShippingDTO Shipping { get; set; }
        [JsonProperty("payments")]
        public PayPalPaymentsDTO Payments { get; set; }
    }
}

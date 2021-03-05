using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.PayPalDTOs
{
    public class PayPalAmountDTO
    {
        [JsonProperty("value")]
        public string Value { get; set; }
        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }
    }
}

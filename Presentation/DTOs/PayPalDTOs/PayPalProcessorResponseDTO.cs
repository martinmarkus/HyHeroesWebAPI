using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.PayPalDTOs
{
    public class PayPalProcessorResponseDTO
    {
        [JsonProperty("avs_code")]
        public string AvsCode { get; set; }

        [JsonProperty("cvv_code")]
        public string CvvCode { get; set; }

        [JsonProperty("response_code")]
        public string ResponseCode { get; set; }

        [JsonProperty("payment_advice_code")]
        public string PaymentAdviceCode { get; set; }
    }
}

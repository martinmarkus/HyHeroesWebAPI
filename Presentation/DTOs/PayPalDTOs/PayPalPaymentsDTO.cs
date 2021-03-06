using System.Collections.Generic;
using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.PayPalDTOs
{
    public class PayPalPaymentsDTO
    {
        [JsonProperty("authorizations")]
        public List<PayPalPaymentAuthorizationDTO> Authorizations { get; set; }

        [JsonProperty("captures")]
        public List<PayPalPaymentCaptureDTO> Captures { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.PayPalDTOs
{
    public class PayPalPlatformFeeDTO
    {
        [JsonProperty("amount")]
        public PayPalAmountDTO Amount { get; set; }
        [JsonProperty("payee")]
        public PayPalPayeeDTO Payee { get; set; }
    }
}

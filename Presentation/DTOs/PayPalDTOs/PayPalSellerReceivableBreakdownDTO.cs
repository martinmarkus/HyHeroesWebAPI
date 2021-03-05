using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.PayPalDTOs
{
    public class PayPalSellerReceivableBreakdownDTO
    {
        [JsonProperty("paypal_fee")]
        public PayPalAmountDTO PayPalFee { get; set; }
        [JsonProperty("gross_amount")]
        public PayPalAmountDTO GrossAmount { get; set; }
        [JsonProperty("net_amount")]
        public PayPalAmountDTO NetAmount { get; set; }
    }
}

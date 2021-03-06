using System.Collections.Generic;
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

        [JsonProperty("paypal_fee_in_receivable_currency")]
        public PayPalAmountDTO PayPalFeeInReceivableCurrency { get; set; }

        [JsonProperty("receivable_amount")]
        public PayPalAmountDTO ReceivableAmount { get; set; }

        [JsonProperty("exchange_rate")]
        public PayPalAmountDTO ExchangeRate { get; set; }

        [JsonProperty("platform_fees")]
        public List<PayPalPlatformFeeDTO> PlatformFees { get; set; }
    }
}

using HyHeroesWebAPI.ApplicationCore.Enums;
using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.StatisticDTOs
{
    public class PaymentTypeStatDTO
    {
        [JsonProperty("paymentType")]
        public PaymentType PaymentType { get; set; }

        [JsonProperty("purchaseCount")]
        public int PurchaseCount { get; set; }

        [JsonProperty("purchaseCurrencySum")]
        public int PurchaseCurrencySum { get; set; }

        [JsonProperty("purchaseKreditSum")]
        public int PurchaseKreditSum { get; set; }
    }
}

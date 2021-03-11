using HyHeroesWebAPI.Infrastructure.Infrastructure.ConfigObjects;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.DTOs.PayPalDTOs
{
    public class PayPalPurchaseTypeListDTO
    {
        [JsonProperty("payPalPurchaseTypes")]
        public IList<PayPalPurchaseType> PayPalPurchaseTypes { get; set; } = new List<PayPalPurchaseType>();
    }
}

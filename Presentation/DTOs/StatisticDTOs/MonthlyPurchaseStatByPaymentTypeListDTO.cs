using Newtonsoft.Json;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.DTOs.StatisticDTOs
{
    public class MonthlyPurchaseStatByPaymentTypeListDTO
    {
        [JsonProperty("monthlyEDSMSStats")]
        public IList<MonthlyPurchaseStatByPaymentTypeDTO> MonthlyEDSMSStats { get; set; }

        [JsonProperty("monthlyBarionStats")]
        public IList<MonthlyPurchaseStatByPaymentTypeDTO> MonthlyBarionStats { get; set; }

        [JsonProperty("monthlyPayPalStats")]
        public IList<MonthlyPurchaseStatByPaymentTypeDTO> MonthlyPayPalStats { get; set; }

        [JsonProperty("monthlyBankTransferStats")]
        public IList<MonthlyPurchaseStatByPaymentTypeDTO> MonthlyBankTransferStats { get; set; }

    }
}

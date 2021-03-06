using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.BarionDTOs
{
    public class BarionTransactionStateDTO
    {
        [JsonProperty("transactionState")]
        public string TransactionState { get; set; }
    }
}

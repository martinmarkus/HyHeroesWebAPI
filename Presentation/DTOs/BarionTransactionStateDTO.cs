using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class BarionTransactionStateDTO
    {
        [JsonProperty("transactionState")]
        public string TransactionState { get; set; }
    }
}

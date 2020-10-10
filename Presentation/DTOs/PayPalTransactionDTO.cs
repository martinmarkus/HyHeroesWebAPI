using Newtonsoft.Json;
using System;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class PayPalTransactionDTO
    {
        [JsonProperty("transactionId")]
        public Guid TransactionId { get; set; }
    }
}

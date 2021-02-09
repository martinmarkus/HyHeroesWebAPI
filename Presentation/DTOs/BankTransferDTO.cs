using Newtonsoft.Json;
using System;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class BankTransferDTO
    {
        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("transferCode")]
        public string TransferCode { get; set; }

        [JsonProperty("kreditValue")]
        public int KreditValue { get; set; }

        [JsonProperty("currencyValue")]
        public int CurrencyValue { get; set; }

        [JsonProperty("startDate")]
        public DateTime StartDate { get; set; }
    }
}

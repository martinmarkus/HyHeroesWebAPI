using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class StartedBankTransferDTO
    {
        [JsonProperty("transferCode")]
        public string TransferCode { get; set; }

        [JsonProperty("kreditValue")]
        public int KreditValue { get; set; }

        [JsonProperty("currencyValue")]
        public int CurrencyValue { get; set; }

        [JsonProperty("sellerAccountOwner")]
        public string SellerAccountOwner { get; set; }

        [JsonProperty("sellerBankName")]
        public string SellerBankName { get; set; }

        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }
    }
}

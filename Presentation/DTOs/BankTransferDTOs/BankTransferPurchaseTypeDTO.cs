using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.BankTransferDTOs
{
    public class BankTransferPurchaseTypeDTO
    {
        [JsonProperty("grossValue")]
        public int GrossValue { get; set; }

        [JsonProperty("kreditValue")]
        public int KreditValue { get; set; }
    }
}

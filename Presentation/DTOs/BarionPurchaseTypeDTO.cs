using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class BarionPurchaseTypeDTO
    {
        [JsonProperty("grossValue")]
        public int GrossValue { get; set; }

        [JsonProperty("kreditValue")]
        public int KreditValue { get; set; }
    }
}

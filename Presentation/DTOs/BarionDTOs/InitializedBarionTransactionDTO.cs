using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.BarionDTOs
{
    public class InitializedBarionTransactionDTO
    {
        [JsonProperty("gatewayURL")]
        public string GatewayURL { get; set; }
    }
}

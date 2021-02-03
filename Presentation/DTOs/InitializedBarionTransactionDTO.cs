using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class InitializedBarionTransactionDTO
    {
        [JsonProperty("gatewayURL")]
        public string GatewayURL { get; set; }
    }
}

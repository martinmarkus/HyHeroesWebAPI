using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class ActualValueOfOneKreditDTO
    {
        [JsonProperty("value")]
        public decimal Value { get; set; }
    }
}

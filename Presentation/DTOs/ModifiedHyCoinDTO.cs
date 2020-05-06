using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class ModifiedHyCoinDTO
    {
        [JsonProperty("newValue")]
        public int NewValue { get; set; }
    }
}

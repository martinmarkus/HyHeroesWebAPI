using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class ModifiedKreditDTO
    {
        [JsonProperty("newValue")]
        public decimal NewValue { get; set; }
    }
}

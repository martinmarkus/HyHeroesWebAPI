using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.UserDTOs
{
    public class ModifiedHyCoinDTO
    {
        [JsonProperty("newValue")]
        public int NewValue { get; set; }
    }
}

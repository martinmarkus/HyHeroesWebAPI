using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.UserDTOs
{
    public class ModifiedKreditDTO
    {
        [JsonProperty("newValue")]
        public decimal NewValue { get; set; }
    }
}

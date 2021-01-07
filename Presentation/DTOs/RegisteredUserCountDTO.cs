using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class RegisteredUserCountDTO
    {
        [JsonProperty("registeredUserCount")]
        public int RegisteredUserCount { get; set; }
    }
}

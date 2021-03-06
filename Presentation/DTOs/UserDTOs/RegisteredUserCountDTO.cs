using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.UserDTOs
{
    public class RegisteredUserCountDTO
    {
        [JsonProperty("registeredUserCount")]
        public int RegisteredUserCount { get; set; }
    }
}

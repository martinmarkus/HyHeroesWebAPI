using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class ZipCode
    {
        [JsonProperty("zip")]
        public int Zip { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }
    }
}

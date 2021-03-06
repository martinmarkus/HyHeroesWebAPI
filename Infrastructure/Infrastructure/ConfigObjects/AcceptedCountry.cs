using Newtonsoft.Json;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.ConfigObjects
{
    public class AcceptedCountry
    {
        [JsonProperty("countryName")]
        public string CountryName { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
    }
}

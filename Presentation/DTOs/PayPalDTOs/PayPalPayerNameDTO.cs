using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.PayPalDTOs
{
    public class PayPalPayerNameDTO
    {
        [JsonProperty("given_name")]
        public string GivenName { get; set; }
        [JsonProperty("surname")]
        public string Surname { get; set; }
    }
}

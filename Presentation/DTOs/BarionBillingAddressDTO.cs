using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class BarionBillingAddressDTO
    {
        [Required]
        [JsonProperty("country")]
        public string Country { get; set; }

        [Required]
        [JsonProperty("city")]
        public string City { get; set; }

        [Required]
        [JsonProperty("zip")]
        public string Zip { get; set; }

        [Required]
        [JsonProperty("street")]
        public string Street { get; set; }
    }
}

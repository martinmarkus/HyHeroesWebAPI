using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs.PayPalDTOs
{
    public class PayPalBillingAddressDTO
    {
        [Required]
        [JsonProperty("country")]
        public string Country { get; set; }

        [Required]
        [JsonProperty("city")]
        public string City { get; set; }

        [Required]
        [JsonProperty("zip")]
        public int Zip { get; set; }

        [Required]
        [JsonProperty("street")]
        public string Street { get; set; }
    }
}

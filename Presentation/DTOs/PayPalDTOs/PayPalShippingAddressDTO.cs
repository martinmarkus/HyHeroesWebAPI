using Newtonsoft.Json;

namespace HyHeroesWebAPI.Presentation.DTOs.PayPalDTOs
{
    public class PayPalShippingAddressDTO
    {
        [JsonProperty("address_line_1")]
        public string AddressLineOne { get; set; }

        [JsonProperty("address_line_2")]
        public string AddressLineTwo { get; set; }

        [JsonProperty("admin_area_1")]
        public string AdminAreaOne { get; set; }

        [JsonProperty("admin_area_2")]
        public string AdminAreaTwo{ get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }
    }
}

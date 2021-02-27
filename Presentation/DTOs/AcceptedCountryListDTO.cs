using HyHeroesWebAPI.Infrastructure.Infrastructure.ConfigObjects;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class AcceptedCountryListDTO
    {
        [JsonProperty("acceptedCountries")]
        public IList<AcceptedCountry> AcceptedCountries { get; set; } = new List<AcceptedCountry>();
    }
}

using HyHeroesWebAPI.Presentation.DTOs.NewsDTOs;
using HyHeroesWebAPI.Presentation.DTOs.ProductDTOs;
using HyHeroesWebAPI.Presentation.DTOs.UserDTOs;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.DTOs.WebsiteDTOs
{
    public class HomeDTO
    {
        [JsonProperty("authenticatedUser")]
        public AuthenticatedUserDTO AuthenticatedUser { get; set; }

        [JsonProperty("news")]
        public IList<NewsDTO> News { get; set; }

        [JsonProperty("lastPurchases")]
        public PurchasedProductListDTO LastPurchases { get; set; }
    }
}

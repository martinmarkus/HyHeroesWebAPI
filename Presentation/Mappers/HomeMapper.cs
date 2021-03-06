using HyHeroesWebAPI.Presentation.DTOs.NewsDTOs;
using HyHeroesWebAPI.Presentation.DTOs.ProductDTOs;
using HyHeroesWebAPI.Presentation.DTOs.UserDTOs;
using HyHeroesWebAPI.Presentation.DTOs.WebsiteDTOs;
using HyHeroesWebAPI.Presentation.Mappers.Interfaces;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.Mappers
{
    public class HomeMapper : IHomeMapper
    {
        public HomeDTO MapToHomeDTO(
            AuthenticatedUserDTO user,
            IList<NewsDTO> news,
            PurchasedProductListDTO lastPurchases) =>
            new HomeDTO()
            {
                AuthenticatedUser = user,
                News = news,
                LastPurchases = lastPurchases
            };
    }
}

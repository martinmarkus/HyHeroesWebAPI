using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs.NewsDTOs;
using HyHeroesWebAPI.Presentation.DTOs.ProductDTOs;
using HyHeroesWebAPI.Presentation.DTOs.UserDTOs;
using HyHeroesWebAPI.Presentation.DTOs.WebsiteDTOs;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.Mappers.Interfaces
{
    public interface IHomeMapper
    {
        HomeDTO MapToHomeDTO(
            AuthenticatedUserDTO user,
            IList<NewsDTO> news,
            PurchasedProductListDTO lastPurchases);
    }
}

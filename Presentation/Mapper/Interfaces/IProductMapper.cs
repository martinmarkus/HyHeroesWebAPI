using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.Mapper.Interfaces
{
    public interface IProductMapper
    {
        ProductDTO Map(Product product);

        IList<ProductDTO> MapAll(IList<Product> products);
    }
}
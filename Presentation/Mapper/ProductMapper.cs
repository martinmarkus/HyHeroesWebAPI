using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mapper.Interfaces;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.Mapper
{
    public class ProductMapper : IProductMapper
    {
        public ProductDTO Map(Product product) =>
            new ProductDTO()
            {
                Name = product?.Name,
                Price = product.Price,
                Description = product?.Description,
                InGameActivatorCommand = product?.InGameActivatorCommand,
                InGameDeactivatorCommand = product?.InGameDeactivatorCommand
            };

        public IList<ProductDTO> MapAll(IList<Product> products)
        {
            IList<ProductDTO> productDTOs = new List<ProductDTO>();

            foreach (var product in products)
            {
                productDTOs.Add(Map(product));
            }

            return productDTOs;
        }
    }
}

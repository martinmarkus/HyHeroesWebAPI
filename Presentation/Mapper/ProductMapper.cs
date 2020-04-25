using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mapper.Interfaces;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.Mapper
{
    public class ProductMapper : IProductMapper
    {
        public ProductDTO MapToProductDTO(Product product) =>
            new ProductDTO()
            {
                Name = product?.Name,
                Price = product.Price,
                Description = product?.Description,
                InGameActivatorCommand = product?.InGameActivatorCommand,
                InGameDeactivatorCommand = product?.InGameDeactivatorCommand
            };

        public PurchasedProductDTO MapToPurchasedProductDTO(PurchasedProduct purchasedProduct) =>
            new PurchasedProductDTO()
            {
                Id = purchasedProduct.Id,
                Name = purchasedProduct.Product.Name,
                Price = purchasedProduct.Product.Price,
                Description = purchasedProduct.Product.Description,
                InGameActivatorCommand = purchasedProduct.Product.InGameActivatorCommand,
                InGameDeactivatorCommand = purchasedProduct.Product.InGameDeactivatorCommand,
                PurchaseDate = purchasedProduct.PurchaseDate,
                IsPermanent = purchasedProduct.IsPermanent,
                IsVerified = purchasedProduct.IsVerified,
                ValidityPeriodInDays = purchasedProduct.ValidityPeriodInDays,
                UserName = purchasedProduct.User.UserName,
                Email = purchasedProduct.User.Email,
                RoleName = purchasedProduct.User.Role.Name,
                PermissionLevel = purchasedProduct.User.Role.PermissionLevel,
                IsBanned = purchasedProduct.User.IsBanned,
                UserId = purchasedProduct.UserId,
                ProductId = purchasedProduct.ProductId
            };

        public IList<ProductDTO> MapAllToProductDTO(IList<Product> products)
        {
            var productDTOs = new List<ProductDTO>();

            foreach (var product in products)
            {
                productDTOs.Add(MapToProductDTO(product));
            }

            return productDTOs;
        }

        public IList<PurchasedProductDTO> MapAllToPurchasedProductDTO(IList<PurchasedProduct> purchasedProducts)
        {
            var purchasedProductDTOs = new List<PurchasedProductDTO>();

            foreach (var purchasedProduct in purchasedProducts)
            {
                purchasedProductDTOs.Add(MapToPurchasedProductDTO(purchasedProduct));
            }

            return purchasedProductDTOs;
        }
    }
}

using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mapper.Interfaces;
using System;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.Mapper
{
    public class ProductMapper : IProductMapper
    {
        public ProductDTO MapToProductDTO(Product product) =>
            new ProductDTO()
            {
                Id = product.Id,
                Name = product?.Name,
                PricePerMonth = product.PricePerMonth,
                PermanentPrice = product.PermanentPrice,
                Description = product?.Description,
                InGameActivatorCommand = product?.InGameActivatorCommand,
                InGameDeactivatorCommand = product?.InGameDeactivatorCommand,
                ImageUrl = product?.ImageUrl
            };

        public PurchasedProductDTO MapToPurchasedProductDTO(PurchasedProduct purchasedProduct) =>
            new PurchasedProductDTO()
            {
                Id = purchasedProduct.Id.ToString(),
                ProductName = purchasedProduct.Product.Name,
                PricePerMonth = purchasedProduct.Product.PricePerMonth,
                PermanentPrice = purchasedProduct.Product.PermanentPrice,
                Description = purchasedProduct.Product.Description,
                InGameActivatorCommand = purchasedProduct.Product.InGameActivatorCommand,
                InGameDeactivatorCommand = purchasedProduct.Product.InGameDeactivatorCommand,
                PurchaseDate = purchasedProduct.PurchaseDate,
                IsPermanent = purchasedProduct.IsPermanent,
                IsRepeatable = purchasedProduct.IsRepeatable,
                IsVerified = purchasedProduct.IsVerified,
                IsExpirationVerified = purchasedProduct.IsExpirationVerified,
                ValidityPeriodInMonths = purchasedProduct.ValidityPeriodInMonths,
                UserName = purchasedProduct.User.UserName,
                Email = purchasedProduct.User.Email,
                RoleName = purchasedProduct.User.Role.Name,
                PermissionLevel = purchasedProduct.User.Role.PermissionLevel,
                IsBanned = purchasedProduct.User.IsBanned,
                UserId = purchasedProduct.UserId,
                ProductId = purchasedProduct.ProductId,
                //ActualPurchasePrice = purchasedProduct.ActualPurchasePrice,
                ImageUrl = purchasedProduct?.Product.ImageUrl,
                IsRank = purchasedProduct.Product.IsRank,
                IsOverwrittenByOtherRank = purchasedProduct.IsOverwrittenByOtherRank
            };

        public PurchasedProduct MapToPurchasedProduct(NewPurchasedProductDTO newPurchasedProductDTO, int kreditSpentOn) =>
            new PurchasedProduct()
            {
                PurchaseDate = DateTime.Now,
                IsPermanent = newPurchasedProductDTO.IsPermanent,
                IsRepeatable = newPurchasedProductDTO.IsRepeatable,
                ValidityPeriodInMonths = newPurchasedProductDTO.ValidityPeriodInMonths,
                UserId = newPurchasedProductDTO.UserId,
                ProductId = newPurchasedProductDTO.ProductId,
                KreditSpentOn = kreditSpentOn
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

        public Product MapToProduct(NewProductDTO newProductDTO) =>
            new Product()
            {
                Name = newProductDTO?.Name,
                PricePerMonth = newProductDTO.PricePerMonth,
                PermanentPrice = newProductDTO.PermanentPrice,
                Description = newProductDTO?.Description,
                InGameActivatorCommand = newProductDTO?.InGameActivatorCommand,
                InGameDeactivatorCommand = newProductDTO?.InGameDeactivatorCommand,
                ImageUrl = newProductDTO?.ImageUrl
            };

        public Product MapToProduct(ProductDTO productDTO) =>
            new Product()
            {
                Id = productDTO.Id,
                Name = productDTO?.Name,
                PricePerMonth = productDTO.PricePerMonth,
                PermanentPrice = productDTO.PermanentPrice,
                Description = productDTO?.Description,
                InGameActivatorCommand = productDTO?.InGameActivatorCommand,
                InGameDeactivatorCommand = productDTO?.InGameDeactivatorCommand,
                ImageUrl = productDTO?.ImageUrl
            };
    }
}

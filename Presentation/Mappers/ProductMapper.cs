using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mappers.Interfaces;
using HyHeroesWebAPI.Presentation.Utils;
using System;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.Mappers
{
    public class ProductMapper : IProductMapper
    {
        private readonly ValueConverter _valueConverter;

        public ProductMapper(ValueConverter valueConverter)
        {
            _valueConverter = valueConverter ?? throw new ArgumentException(nameof(valueConverter));
        }

        public ProductDTO MapToProductDTO(Product product)
        {
            var newProduct = new ProductDTO()
            {
                Id = product.Id,
                Name = product?.Name,
                PricePerMonth = product.PricePerMonth,
                PermanentPrice = product.PermanentPrice,
                Description = product?.Description,
                InGameActivatorCommand = product?.InGameActivatorCommand,
                InGameDeactivatorCommand = product?.InGameDeactivatorCommand,
                OneTimeCommand = product?.OneTimeCommand,
                ImageUrl = product?.ImageUrl,
                IsRank = product?.IsRank,
                SingleGameServerId = product.GameServerId.ToString()
            };

            if (product.ProductCategoryId.HasValue)
            {
                newProduct.CategoryId = product.ProductCategoryId.Value.ToString();
            }

            return newProduct;
        }

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
                OneTimeCommand = purchasedProduct.Product.OneTimeCommand,
                LastPurchaseDate = purchasedProduct.LastPurchaseDate,
                IsPermanent = purchasedProduct.IsPermanent,
                IsRepeatable = purchasedProduct.IsRepeatable,
                ValidityPeriodInMonths = purchasedProduct.ValidityPeriodInMonths,
                UserName = purchasedProduct.User.UserName,
                Email = _valueConverter.GetCheckedString(purchasedProduct.User.Email),
                RoleName = purchasedProduct.User.Role.Name,
                PermissionLevel = purchasedProduct.User.Role.PermissionLevel,
                IsBanned = purchasedProduct.User.IsBanned,
                UserId = purchasedProduct.UserId,
                ProductId = purchasedProduct.ProductId,
                KreditSpentOn = purchasedProduct.KreditSpentOn,
                ImageUrl = purchasedProduct?.Product.ImageUrl,
                IsRank = purchasedProduct.Product.IsRank,
                IsOverwrittenByOtherRank = purchasedProduct.IsOverwrittenByOtherRank,
                IsOneTimeCommandRan = purchasedProduct.IsOneTimeCommandRan,
                SingleGameServerId = purchasedProduct.Product.GameServerId.ToString(),
                ExpirationDate = purchasedProduct.IsPermanent 
                    ? "Soha" :
                    purchasedProduct.CreationDate.AddDays(30 *purchasedProduct.ValidityPeriodInMonths).ToString(),
            };

        public PurchasedProduct MapToPurchasedProduct(NewPurchasedProductDTO newPurchasedProductDTO, int kreditSpentOn) =>
            new PurchasedProduct()
            {
                LastPurchaseDate = DateTime.Now,
                IsPermanent = newPurchasedProductDTO.IsPermanent,
                IsRepeatable = newPurchasedProductDTO.IsRepeatable,
                ValidityPeriodInMonths = newPurchasedProductDTO.ValidityPeriodInMonths,
                UserId = newPurchasedProductDTO.UserId,
                ProductId = newPurchasedProductDTO.ProductId,
                KreditSpentOn = kreditSpentOn,
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

        public PurchasedProductListDTO MapAllToPurchasedProductListDTO(IList<PurchasedProduct> purchasedProducts)
        {
            var purchasedProductDTOs = new PurchasedProductListDTO();

            foreach (var purchasedProduct in purchasedProducts)
            {
                purchasedProductDTOs.PurchasedProductDTOs.Add(MapToPurchasedProductDTO(purchasedProduct));
            }

            return purchasedProductDTOs;
        }

        public Product MapToProduct(NewProductDTO newProductDTO)
        {
            var product = new Product()
            {
                Name = newProductDTO?.Name,
                PricePerMonth = newProductDTO.PricePerMonth,
                PermanentPrice = newProductDTO.PermanentPrice,
                Description = newProductDTO?.Description,
                InGameActivatorCommand = newProductDTO?.InGameActivatorCommand,
                InGameDeactivatorCommand = newProductDTO?.InGameDeactivatorCommand,
                OneTimeCommand = newProductDTO?.OneTimeCommand,
                ImageUrl = newProductDTO?.ImageUrl
            };

            if (!string.IsNullOrEmpty(newProductDTO.CategoryId)
                    && Guid.TryParse(newProductDTO.CategoryId, out Guid catId))
            {
                product.ProductCategoryId = catId;
            }

            if (!string.IsNullOrEmpty(newProductDTO.SingleGameServerId)
                    && Guid.TryParse(newProductDTO.SingleGameServerId, out Guid serverId))
            {
                product.GameServerId = serverId;
            }

            return product;
        }

        public Product MapToProduct(ProductDTO productDTO)
        {
            var product = new Product()
            {
                Id = productDTO.Id,
                Name = productDTO?.Name,
                PricePerMonth = productDTO.PricePerMonth,
                PermanentPrice = productDTO.PermanentPrice,
                Description = productDTO?.Description,
                InGameActivatorCommand = productDTO?.InGameActivatorCommand,
                InGameDeactivatorCommand = productDTO?.InGameDeactivatorCommand,
                OneTimeCommand = productDTO?.OneTimeCommand,
                ImageUrl = productDTO?.ImageUrl
            };

            if (!string.IsNullOrEmpty(productDTO.CategoryId)
                    && Guid.TryParse(productDTO.CategoryId, out Guid catId))
            {
                product.ProductCategoryId = catId;
            }

            if (!string.IsNullOrEmpty(productDTO.SingleGameServerId)
                && Guid.TryParse(productDTO.SingleGameServerId, out Guid gameServerId))
            {
                product.GameServerId = gameServerId;
            }

            return product;
        }

        public IList<CategoryDTO> MapAllToCategoryDTO(IList<ProductCategory> categories)
        {
            var categoriesDTO = new List<CategoryDTO>();

            foreach (var cat in categories)
            {
                categoriesDTO.Add(new CategoryDTO()
                {
                    CategoryId = cat.Id,
                    IsUsed = cat.IsUsed,
                    CategoryName = cat.CategoryName,
                    Priority = cat.Priority,
                    ImageUrl = cat.ImageUrl
                });
            }

            return categoriesDTO;
        }

        public ProductCategory MapToCategory(NewCategoryDTO productCategoryDTO) =>
            new ProductCategory()
            {
                CategoryName = productCategoryDTO.CategoryName,
                IsUsed = productCategoryDTO.IsUsed,
                Priority = productCategoryDTO.Priority,
                ImageUrl = productCategoryDTO.ImageUrl
            };
    }
}

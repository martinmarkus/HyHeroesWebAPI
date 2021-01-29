using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.Mapper.Interfaces
{
    public interface IProductMapper
    {
        ProductDTO MapToProductDTO(Product product);

        Product MapToProduct(NewProductDTO newProductDTO);

        PurchasedProductDTO MapToPurchasedProductDTO(PurchasedProduct purchasedProduct);

        IList<ProductDTO> MapAllToProductDTO(IList<Product> products);

        IList<PurchasedProductDTO> MapAllToPurchasedProductDTO(IList<PurchasedProduct> purchasedProducts);

        PurchasedProduct MapToPurchasedProduct(NewPurchasedProductDTO newPurchasedProductDTO, int kreditSpentOn);
        
        Product MapToProduct(ProductDTO productDTO);

        IList<CategoryDTO> MapAllToCategoryDTO(IList<ProductCategory> categories);
        
        ProductCategory MapToCategory(NewCategoryDTO productCategoryDTO);

        PurchasedProductListDTO MapAllToPurchasedProductListDTO(IList<PurchasedProduct> purchasedProducts);
    }
}

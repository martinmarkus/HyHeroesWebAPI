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

        PurchasedProduct MapToPurchasedProduct(NewPurchasedProductDTO newPurchasedProductDTO, decimal actualValueOfOneKredit);
        
        Product MapToProduct(ProductDTO productDTO);
    }
}

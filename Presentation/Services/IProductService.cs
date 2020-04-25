using HyHeroesWebAPI.Presentation.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    public interface IProductService
    {
        Task<IList<ProductDTO>> GetAllProducts()
            ;
        Task<IList<PurchasedProductDTO>> GetAllUnverifiedPurchasedProducts();

        Task<IList<PurchasedProductDTO>> GetAllVerifiedPurchasedProducts();

        Task<bool> VerifyPurchasedProduct(Guid purchasedProductId);

        Task<bool> VerifyPurchasedProducts(IList<Guid> purchasedProductIds);

        Task<IList<PurchasedProductDTO>> GetExpiredPurchasedProducts();
    }
}
using HyHeroesWebAPI.Presentation.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    public interface IProductService
    {
        Task<IList<ProductDTO>> GetAllProductsAsync()
            ;
        Task<IList<PurchasedProductDTO>> GetAllUnverifiedPurchasedProductsAsync();

        Task<IList<PurchasedProductDTO>> GetAllVerifiedPurchasedProductsAsync();

        Task<bool> VerifyPurchasedProductAsync(Guid purchasedProductId);

        Task<bool> VerifyPurchasedProductsAsync(IList<Guid> purchasedProductIds);

        Task<IList<PurchasedProductDTO>> GetExpiredPurchasedProductsAsync();
    }
}
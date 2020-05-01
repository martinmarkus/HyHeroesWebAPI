using HyHeroesWebAPI.Presentation.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IProductService
    {
        Task<IList<ProductDTO>> GetAllProductsAsync()
            ;
        Task<IList<PurchasedProductDTO>> GetAllUnverifiedPurchasedProductsAsync();

        Task<IList<PurchasedProductDTO>> GetAllVerifiedPurchasedProductsAsync();

        Task<bool> VerifyPurchasedProductAsync(Guid purchasedProductId);

        Task<bool> VerifyPurchasedProductsAsync(IList<Guid> purchasedProductIds);

        Task<IList<PurchasedProductDTO>> GetUnverifiedExpiredPurchasedProductsAsync();

        Task<IList<PurchasedProductDTO>> GetAllExpiredPurchasedProductsAsync();

        Task<bool> VerifyExpiredProductAsync(Guid purchasedProductId);

        Task<bool> VerifyExpiredProductsAsync(IList<Guid> purchasedProductIds);

        Task PurchaseProductAsync(NewPurchasedProductDTO newPurchasedProductDTO);

        Task<IList<PurchasedProductDTO>> GetAllActivePurchasesByUserNameAsync(string userName);

        Task<IList<PurchasedProductDTO>> GetAllActivePurchasesByUserEmailAsync(string email);
    }
}
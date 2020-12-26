using HyHeroesWebAPI.Presentation.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IProductService
    {
        Task<IList<ProductDTO>> GetAllProductsAsync();
       
        Task<IList<PurchasedProductDTO>> GetAllUnverifiedPurchasedProductsAsync(Guid serverId);

        Task<IList<PurchasedProductDTO>> GetAllVerifiedPurchasedProductsAsync();

        Task<bool> VerifyPurchasedProductsAsync(ActivatedPurchasesOnServerDTO activationsOnServerDTO);

        Task<IList<PurchasedProductDTO>> GetUnverifiedExpiredPurchasedProductsAsync(Guid serverId);

        Task<IList<PurchasedProductDTO>> GetAllExpiredPurchasedProductsAsync();

        Task<bool> VerifyExpiredProductsAsync(ExpiredProductsVerificationDTO expiredProductsVerificationDTO);

        Task PurchaseProductAsync(NewPurchasedProductDTO newPurchasedProductDTO);

        Task<IList<PurchasedProductDTO>> GetAllActivePurchasesByUserNameAsync(string userName);

        Task<IList<PurchasedProductDTO>> GetAllActivePurchasesByUserEmailAsync(string email);

        Task<ActualValueOfOneKreditDTO> GetActualValueOfOneKreditAsync();

        Task<ActualValueOfOneKreditDTO> SetActualValueOfOneKreditAsync(ActualValueOfOneKreditDTO actualValueOfOneKreditDTO);

        Task<bool> ReactivatePermanentRankAsync(ReactivatePermanentRankDTO reactivatePermanentRankDTO);
        
        Task<bool> CreateNewProductAsync(NewProductDTO newProductDTO);
       
        Task<bool> UpdateProductAsync(ProductDTO productDTO);
        
        Task<bool> DeleteProductAsync(Guid productId);
        
        Task<IList<PurchasedProductDTO>> GetAllByUserNameAsync(string userName);
        
        Task UpdatePurchasesForNewGameServerAsync(string userName, string password);
    }
}
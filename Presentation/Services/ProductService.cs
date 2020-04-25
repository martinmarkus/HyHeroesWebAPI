using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mapper.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IPurchasedProductRepository _purchasedProductRepository;

        private readonly IProductMapper _productMapper;

        public ProductService(
            IProductRepository productRepository,
            IPurchasedProductRepository purchasedProductRepository,
            IProductMapper productMapper)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            _purchasedProductRepository = purchasedProductRepository ?? throw new ArgumentNullException(nameof(purchasedProductRepository));
            _productMapper = productMapper ?? throw new ArgumentNullException(nameof(productMapper));
        }

        public async Task<IList<ProductDTO>> GetAllProducts() =>
            _productMapper.MapAllToProductDTO(
                await _productRepository.GetAllProducts());

        public async Task<IList<PurchasedProductDTO>> GetAllUnverifiedPurchasedProducts() =>
            _productMapper.MapAllToPurchasedProductDTO(
                await _purchasedProductRepository.GetAllUnverifiedPurchasedProductsAsync());

        public async Task<IList<PurchasedProductDTO>> GetAllVerifiedPurchasedProducts() =>
            _productMapper.MapAllToPurchasedProductDTO(
                await _purchasedProductRepository.GetAllVerifiedPurchasedProductsAsync());

        public async Task<bool> VerifyPurchasedProduct(Guid purchasedProductId)
        {
            var existingPurchasedProduct = await _purchasedProductRepository.GetByIdAsync(purchasedProductId);

            existingPurchasedProduct.IsVerified = true;

            await _purchasedProductRepository.UpdateAsync(existingPurchasedProduct);

            return (await _purchasedProductRepository.GetByIdAsync(purchasedProductId)).IsVerified;
        }

        public async Task<bool> VerifyPurchasedProducts(IList<Guid> purchasedProductIds)
        {
            var existingPurchasedProducts = await _purchasedProductRepository.GetAllByIdsAsync(purchasedProductIds);

            foreach (var purchasedProduct in existingPurchasedProducts)
            {
                purchasedProduct.IsVerified = true;
            }

            await _purchasedProductRepository.UpdateAllAsync(existingPurchasedProducts);

            return true;
        }

        public async Task<IList<PurchasedProductDTO>> GetExpiredPurchasedProducts() =>
            _productMapper.MapAllToPurchasedProductDTO(
                await _purchasedProductRepository.GetExpiredPurchasedProducts());
    }
}

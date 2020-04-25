using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
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

        public async Task<IList<ProductDTO>> GetAllProductsAsync() =>
            _productMapper.MapAllToProductDTO(
                await _productRepository.GetAllProductsAsync());

        public async Task<IList<PurchasedProductDTO>> GetAllUnverifiedPurchasedProductsAsync() =>
            _productMapper.MapAllToPurchasedProductDTO(
                await _purchasedProductRepository.GetAllUnverifiedPurchasedProductsAsync());

        public async Task<IList<PurchasedProductDTO>> GetAllVerifiedPurchasedProductsAsync() =>
            _productMapper.MapAllToPurchasedProductDTO(
                await _purchasedProductRepository.GetAllVerifiedPurchasedProductsAsync());

        public async Task<bool> VerifyPurchasedProductAsync(Guid purchasedProductId)
        {
            var existingPurchasedProduct = await _purchasedProductRepository.GetByIdAsync(purchasedProductId);

            if (existingPurchasedProduct == null)
            {
                throw new NotFoundException();
            }

            existingPurchasedProduct.IsVerified = true;

            await _purchasedProductRepository.UpdateAsync(existingPurchasedProduct);

            return (await _purchasedProductRepository.GetByIdAsync(purchasedProductId)).IsVerified;
        }

        public async Task<bool> VerifyPurchasedProductsAsync(IList<Guid> purchasedProductIds)
        {
            var existingPurchasedProducts = await _purchasedProductRepository.GetAllByIdsAsync(purchasedProductIds);

            if (existingPurchasedProducts == null)
            {
                throw new NotFoundException();
            }

            foreach (var purchasedProduct in existingPurchasedProducts)
            {
                purchasedProduct.IsVerified = true;
            }

            await _purchasedProductRepository.UpdateAllAsync(existingPurchasedProducts);

            return true;
        }

        public async Task<IList<PurchasedProductDTO>> GetExpiredPurchasedProductsAsync() =>
            _productMapper.MapAllToPurchasedProductDTO(
                await _purchasedProductRepository.GetExpiredPurchasedProductsAsync());
    }
}

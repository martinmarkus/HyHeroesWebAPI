using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Infrastructure.Persistence.UnitOfWork;
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
        private readonly IUserRepository _userRepository;
        private readonly IPurchasedProductRepository _purchasedProductRepository;
        private readonly IProductMapper _productMapper;
        private IUnitOfWork _unitOfWork;

        public ProductService(
            IProductRepository productRepository,
            IUserRepository userRepository,
            IPurchasedProductRepository purchasedProductRepository,
            IProductMapper productMapper,
            IUnitOfWork unitOfWork)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _purchasedProductRepository = purchasedProductRepository ?? throw new ArgumentNullException(nameof(purchasedProductRepository));
            _productMapper = productMapper ?? throw new ArgumentNullException(nameof(productMapper));
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
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

        public async Task<IList<PurchasedProductDTO>> GetUnverifiedExpiredPurchasedProductsAsync() =>
            _productMapper.MapAllToPurchasedProductDTO(
                await _purchasedProductRepository.GetUnverifiedExpiredPurchasedProductsAsync());

        public async Task<IList<PurchasedProductDTO>> GetAllExpiredPurchasedProductsAsync() =>
            _productMapper.MapAllToPurchasedProductDTO(
                await _purchasedProductRepository.GetAllExpiredPurchasedProductsAsync());

        public async Task<bool> VerifyExpiredProductAsync(Guid purchasedProductId)
        {
            var existingPurchasedProduct = await _purchasedProductRepository.GetByIdAsync(purchasedProductId);

            if (existingPurchasedProduct == null)
            {
                throw new NotFoundException();
            }

            existingPurchasedProduct.IsExpirationVerified = true;

            await _purchasedProductRepository.UpdateAsync(existingPurchasedProduct);

            return (await _purchasedProductRepository.GetByIdAsync(purchasedProductId)).IsVerified;
        }

        public async Task<bool> VerifyExpiredProductsAsync(IList<Guid> purchasedProductIds)
        {
            var existingPurchasedProducts = await _purchasedProductRepository.GetAllByIdsAsync(purchasedProductIds);

            if (existingPurchasedProducts == null)
            {
                throw new NotFoundException();
            }

            foreach (var purchasedProduct in existingPurchasedProducts)
            {
                purchasedProduct.IsExpirationVerified = true;
            }

            await _purchasedProductRepository.UpdateAllAsync(existingPurchasedProducts);

            return true;
        }

        public async Task AddPurchasedProductAsync(NewPurchasedProductDTO newPurchasedProductDTO)
        {
            var user = await _userRepository.GetByIdAsync(newPurchasedProductDTO.UserId);
            if (user == null)
            {
                throw new NotFoundException();
            }
            var product = await _productRepository.GetByIdAsync(newPurchasedProductDTO.ProductId);
            if (product == null)
            {
                throw new NotFoundException();
            }

            using (var transaction = _unitOfWork.BeginTransaction())
            {
                try
                {
                    ExecutePaymentChargingAsync(newPurchasedProductDTO, product, user);
                    AddNewPurchaseAsync(newPurchasedProductDTO);
                    await _userRepository.SaveChangesAsync();
                    await _purchasedProductRepository.SaveChangesAsync();

                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }
        }

        private async void ExecutePaymentChargingAsync(
            NewPurchasedProductDTO newPurchasedProductDTO,
            Product product,
            User user)
        {
            if (newPurchasedProductDTO.IsPermanent)
            {
                if (user.Currency < product.PermanentPrice)
                {
                    throw new NotEnoughCurrencyException(user.UserName);
                }
                else
                {
                    user.Currency -= product.PermanentPrice;
                    await _userRepository.UpdateWithoutSaveAsync(user);
                }
            }
            else
            {
                var fullMonthsPrice = product.PricePerMonth * Math.Abs(newPurchasedProductDTO.ValidityPeriodInMonths);
                if (user.Currency < fullMonthsPrice)
                {
                    throw new NotEnoughCurrencyException(user.UserName);
                }
                else
                {
                    user.Currency -= fullMonthsPrice;
                    await _userRepository.UpdateWithoutSaveAsync(user);
                }
            }
        }

        private async void AddNewPurchaseAsync(NewPurchasedProductDTO newPurchasedProductDTO)
        {
            var purchasedProduct = _productMapper.MapToPurchasedProduct(newPurchasedProductDTO);
            purchasedProduct.IsVerified = false;
            purchasedProduct.IsExpirationVerified = false;

            await _purchasedProductRepository.AddWithoutSaveAsync(purchasedProduct);
        }
    }
}

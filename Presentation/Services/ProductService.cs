using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Infrastructure.Persistence.UnitOfWork;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mapper.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
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
                await _purchasedProductRepository.GetAllUnverifiedPurchasedProductsAsync(false));

        public async Task<IList<PurchasedProductDTO>> GetAllVerifiedPurchasedProductsAsync() =>
            _productMapper.MapAllToPurchasedProductDTO(
                await _purchasedProductRepository.GetAllVerifiedPurchasedProductsAsync(false));

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
            var existingPurchasedProducts = await _purchasedProductRepository.GetAllByIdsAsync(purchasedProductIds, false);

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
                await _purchasedProductRepository.GetUnverifiedExpiredPurchasedProductsAsync(true));

        public async Task<IList<PurchasedProductDTO>> GetAllExpiredPurchasedProductsAsync() =>
            _productMapper.MapAllToPurchasedProductDTO(
                await _purchasedProductRepository.GetAllExpiredPurchasedProductsAsync(true));

        public async Task<IList<PurchasedProductDTO>> GetAllActivePurchasesByUserNameAsync(string userName) =>
            _productMapper.MapAllToPurchasedProductDTO(
                await _purchasedProductRepository.GetAllActivePurchasesByUserNameAsync(userName, false));

        public async Task<IList<PurchasedProductDTO>> GetAllActivePurchasesByUserEmailAsync(string email) =>
            _productMapper.MapAllToPurchasedProductDTO(
                await _purchasedProductRepository.GetAllActivePurchasesByEmailAsync(email, true));

        public async Task<ActualValueOfOneKreditDTO> GetActualValueOfOneKreditAsync()
        {
            var newValue = await _purchasedProductRepository.GetActualValueOfOneKreditAsync();

            return new ActualValueOfOneKreditDTO() {
                Value = newValue.Value
            };
        }
        public async Task<ActualValueOfOneKreditDTO> SetActualValueOfOneKreditAsync(ActualValueOfOneKreditDTO actualValueOfOneKreditDTO)
        {
            var newValue = await _purchasedProductRepository.SetActualValueOfOneKreditAsync(actualValueOfOneKreditDTO.Value);

            return new ActualValueOfOneKreditDTO()
            {
                Value = newValue.Value
            };
        }

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
            var existingPurchasedProducts = await _purchasedProductRepository.GetAllByIdsAsync(purchasedProductIds, true);

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

        public async Task PurchaseProductAsync(NewPurchasedProductDTO newPurchasedProductDTO)
        {
            var user = await _userRepository.GetByIdAsync(newPurchasedProductDTO.UserId);
            var product = await _productRepository.GetByIdAsync(newPurchasedProductDTO.ProductId);
            if (user == null || product == null)
            {
                throw new NotFoundException();
            }

            if ((!newPurchasedProductDTO.IsPermanent && !newPurchasedProductDTO.IsRepeatable)
                || (newPurchasedProductDTO.IsPermanent && newPurchasedProductDTO.IsRepeatable)
                || (!newPurchasedProductDTO.IsPermanent && newPurchasedProductDTO.ValidityPeriodInMonths <= 0))
            {
                throw new InvalidPurchaseException();
            }

            var activePermanentNonPrepeatablePurchases = await _purchasedProductRepository
                .GetAllNonRepeatablePermanentPurchasesByUserNameAsync(user.UserName, product.Id, false);
            if (activePermanentNonPrepeatablePurchases != null && activePermanentNonPrepeatablePurchases.Count > 0)
            {
                throw new AlreadyPurchasedException();
            }

            if (!newPurchasedProductDTO.IsPermanent && newPurchasedProductDTO.IsRepeatable)
            {
                var activeRepeatableTemporaryPurchase = await _purchasedProductRepository
                    .GetRepeatableTemporarytPurchaseByUserNameAsync(user.UserName, product.Id, false);

                if (activeRepeatableTemporaryPurchase != null)
                {
                    await ExecutePurchaseForValidityExtendingAsync(
                        activeRepeatableTemporaryPurchase,
                        newPurchasedProductDTO,
                        user,
                        product);

                    return;
                }
            }

            await ExecutePurchaseAsync(newPurchasedProductDTO, user, product);
        }

        private async Task ExecutePurchaseForValidityExtendingAsync(
            PurchasedProduct activeRepeatableTemporaryPurchase,
            NewPurchasedProductDTO newPurchasedProductDTO, 
            User user,
            Product product)
        {
            var transaction = _unitOfWork.BeginTransaction();
            try
            {
                var isCharged = await ExecutePaymentChargingAsync(newPurchasedProductDTO, product, user);
                if (!isCharged)
                {
                    throw new NotEnoughCurrencyException();
                }

                var anotherRanks = await _unitOfWork.PurchasedProductRepository.GetAllActivePurchasesByUserNameAsync(user.UserName, true);
                var productOfNewPurchase = await _unitOfWork.ProductRepository.GetByIdAsync(activeRepeatableTemporaryPurchase.ProductId);
                if (productOfNewPurchase.IsRank && anotherRanks.Count > 0)
                {
                    await OverwriteAllActiveRanksAsync(anotherRanks);
                }

                activeRepeatableTemporaryPurchase.ValidityPeriodInMonths += newPurchasedProductDTO.ValidityPeriodInMonths;
                activeRepeatableTemporaryPurchase.IsExpirationVerified = false;
                activeRepeatableTemporaryPurchase.IsOverwrittenByOtherRank = false;


                await _unitOfWork.PurchasedProductRepository.UpdateAsync(activeRepeatableTemporaryPurchase);

                transaction.Commit();
            }
            catch (Exception e)
            {
                transaction.Rollback();
                throw e;
            }
            transaction.Dispose();
        }

        private async Task ExecutePurchaseAsync(
            NewPurchasedProductDTO newPurchasedProductDTO,
            User user,
            Product product)
        {
            var transaction = _unitOfWork.BeginTransaction();

            try
            {
                var isCharged = await ExecutePaymentChargingAsync(newPurchasedProductDTO, product, user);
                if (!isCharged)
                {
                    throw new NotEnoughCurrencyException();
                }

                var actualValueOfOneKredit = await _unitOfWork.PurchasedProductRepository.GetActualValueOfOneKreditAsync();
                var purchasedProduct = _productMapper.MapToPurchasedProduct(newPurchasedProductDTO, actualValueOfOneKredit.Value);
                purchasedProduct.IsVerified = false;
                purchasedProduct.IsExpirationVerified = false;

                var anotherRanks = await _unitOfWork.PurchasedProductRepository.GetAllActivePurchasesByUserNameAsync(user.UserName, true);
                var productOfNewPurchase = await _unitOfWork.ProductRepository.GetByIdAsync(purchasedProduct.ProductId);
                if (productOfNewPurchase.IsRank && anotherRanks.Count > 0)
                {
                    await OverwriteAllActiveRanksAsync(anotherRanks);
                }

                await _unitOfWork.PurchasedProductRepository.AddAsync(purchasedProduct);

                transaction.Commit();
            }
            catch (Exception e)
            {
                transaction.Rollback();
                throw e;
            }
            transaction.Dispose();
        }

        private async Task<bool> ExecutePaymentChargingAsync(
            NewPurchasedProductDTO newPurchasedProductDTO,
            Product product,
            User user)
        {
            if (newPurchasedProductDTO.IsPermanent)
            {
                if (user.Currency < product.PermanentPrice)
                {
                    return false;
                }
                else
                {
                    user.Currency -= product.PermanentPrice;
                    await _userRepository.AddAsync(user);
                }
            }
            else
            {
                var fullMonthsPrice = product.PricePerMonth * Math.Abs(newPurchasedProductDTO.ValidityPeriodInMonths);
                if (user.Currency < fullMonthsPrice)
                {
                    return false;
                }
                else
                {
                    user.Currency -= fullMonthsPrice;
                    await _userRepository.AddAsync(user);
                }
            }

            return true;
        }

        private async Task OverwriteAllActiveRanksAsync(IList<PurchasedProduct> alreadyActivatedRanks)
        {
            foreach (var activeRank in alreadyActivatedRanks)
            {
                activeRank.IsOverwrittenByOtherRank = true;
                activeRank.IsExpirationVerified = true;
                //activeRank.IsActive = false;
                await _purchasedProductRepository.UpdateAsync(activeRank);
            }
        }

        public async Task<bool> ReactivatePermanentRankAsync(ReactivatePermanentRankDTO reactivatePermanentRankDTO)
        {
            var reactivatedRank = await _purchasedProductRepository.GetByIdAsync(reactivatePermanentRankDTO.PermanentPurchaseId);

            if (reactivatedRank != null && reactivatedRank.Product.IsRank && reactivatedRank.IsPermanent)
            {
                var anotherRanks = await _unitOfWork.PurchasedProductRepository.GetAllActivePurchasesByUserNameAsync(reactivatePermanentRankDTO.UserName, true);
                if (anotherRanks.Count > 0)
                {
                    await OverwriteAllActiveRanksAsync(anotherRanks);
                }

                reactivatedRank.IsOverwrittenByOtherRank = false;
                reactivatedRank.IsExpirationVerified = false;

                await _unitOfWork.PurchasedProductRepository.UpdateAsync(reactivatedRank);
                return true;
            }

            return false;
        }
    }
}

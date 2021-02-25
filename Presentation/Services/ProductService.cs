using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Infrastructure.Persistence.UnitOfWork;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mappers.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IUserRepository _userRepository;
        private readonly IPurchasedProductRepository _purchasedProductRepository;
        private readonly IPurchaseStateRepository _purchaseStateRepository;
        private readonly IProductCategoryRepository _productCategoryRepository;

        private IUnitOfWork _unitOfWork;

        private readonly IProductMapper _productMapper;

        private readonly IUserService _userService;

        public ProductService(
            IProductRepository productRepository,
            IUserRepository userRepository,
            IPurchasedProductRepository purchasedProductRepository,
            IPurchaseStateRepository purchaseStateRepository,
            IProductCategoryRepository productCategoryRepository,
            IProductMapper productMapper,
            IUserService userService,
            IUnitOfWork unitOfWork)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _purchasedProductRepository = purchasedProductRepository ?? throw new ArgumentNullException(nameof(purchasedProductRepository));
            _productCategoryRepository = productCategoryRepository ?? throw new ArgumentNullException(nameof(productCategoryRepository));
            _purchaseStateRepository = purchaseStateRepository ?? throw new ArgumentNullException(nameof(purchaseStateRepository));

            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));

            _productMapper = productMapper ?? throw new ArgumentNullException(nameof(productMapper));

            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        }

        public async Task<IList<ProductDTO>> GetAllProductsAsync() =>
            _productMapper.MapAllToProductDTO(
                await _productRepository.GetAllRankProductsAsync());

        public async Task<IList<PurchasedProductDTO>> GetAllUnverifiedPurchasedProductsAsync(Guid serverId) =>
            _productMapper.MapAllToPurchasedProductDTO(
                await _purchasedProductRepository.GetUnverifiedPurchasedProductsByServerIdAsync(serverId, false));

        public async Task<IList<PurchasedProductDTO>> GetAllVerifiedPurchasedProductsAsync() =>
            _productMapper.MapAllToPurchasedProductDTO(
                await _purchasedProductRepository.GetAllVerifiedPurchasedProductsAsync(false));

        public async Task<IList<PurchasedProductDTO>> GetUnverifiedExpiredPurchasedProductsAsync(Guid serverId) =>
            _productMapper.MapAllToPurchasedProductDTO(
                await _purchasedProductRepository.GetUnverifiedExpiredPurchasedProductsAsync(serverId, true));

        public async Task<IList<PurchasedProductDTO>> GetAllExpiredPurchasedProductsAsync() =>
            _productMapper.MapAllToPurchasedProductDTO(
                await _purchasedProductRepository.GetAllExpiredPurchasedProductsAsync(true));

        public async Task<IList<PurchasedProductDTO>> GetAllActivePurchasesByUserNameAsync(string userName) =>
            _productMapper.MapAllToPurchasedProductDTO(
                await _purchasedProductRepository.GetAllActivePurchasesByUserNameAsync(userName, false));

        public async Task<IList<PurchasedProductDTO>> GetAllActivePurchasesByUserEmailAsync(string email) =>
            _productMapper.MapAllToPurchasedProductDTO(
                await _purchasedProductRepository.GetAllActivePurchasesByEmailAsync(email, true));

        public async Task<IList<PurchasedProductDTO>> GetAllByUserNameAsync(string userName) =>
            _productMapper.MapAllToPurchasedProductDTO(
                await _purchasedProductRepository.GetAllByUserNameAsync(userName));

        public async Task<bool> VerifyPurchasedProductsAsync(ActivatedPurchasesOnServerDTO activationsDTOs)
        {
            var existingPurchasedProducts = await _purchasedProductRepository.GetAllByIdsAsync(
                activationsDTOs.PurchasedProductIds, 
                false);

            if (existingPurchasedProducts == null)
            {
                throw new NotFoundException();
            }

            foreach (var existingPurchase in existingPurchasedProducts)
            {
                if (!existingPurchase.IsOneTimeCommandRan)
                {
                    existingPurchase.IsOneTimeCommandRan = true;
                    await _purchasedProductRepository.UpdateAsync(existingPurchase);
                }

                foreach (var state in existingPurchase.PurchaseStates)
                {
                    if (state.GameServerId == activationsDTOs.GameServerId)
                    {
                        state.IsActivationVerified = true;
                        await _purchaseStateRepository.UpdateAsync(state);
                        break;
                    }
                }
            }

            return true;
        }

        public async Task<bool> VerifyExpiredProductsAsync(ExpiredProductsVerificationDTO expiredProductsVerificationDTO)
        {
            var existingPurchasedProducts = await _purchasedProductRepository
                .GetAllByIdsAsync(expiredProductsVerificationDTO.PurchasedProductIds, true);

            if (existingPurchasedProducts == null)
            {
                throw new NotFoundException();
            }

            var unverifiedPurchases = existingPurchasedProducts.Where(purchase =>
                    purchase.PurchaseStates.Where(state => 
                            state.IsActive
                            && state.GameServerId == expiredProductsVerificationDTO.GameServerId
                            && !state.IsExpirationVerified)
                    .Any());

            foreach (var unverifiedPurchase in unverifiedPurchases)
            {
                foreach (var state in unverifiedPurchase.PurchaseStates)
                {
                    if (state.GameServerId == expiredProductsVerificationDTO.GameServerId)
                    {
                        state.IsExpirationVerified = true;
                        await _purchaseStateRepository.UpdateAsync(state);
                        break;
                    }
                }
            }

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

            if (!product.IsRank)
            {
                await PurchaseOtherProductAsync(newPurchasedProductDTO, user, product);
                return;
            }

            if ((!newPurchasedProductDTO.IsPermanent && !newPurchasedProductDTO.IsRepeatable)
                || (newPurchasedProductDTO.IsPermanent && newPurchasedProductDTO.IsRepeatable)
                || (!newPurchasedProductDTO.IsPermanent && newPurchasedProductDTO.ValidityPeriodInMonths <= 0))
            {
                throw new InvalidPurchaseException();
            }

            var activePermanentNonPrepeatablePurchases = await _purchasedProductRepository
                .GetAllNonRepeatablePermanentPurchasesByUserNameAsync(user.UserName, product.Id, false);
            if (activePermanentNonPrepeatablePurchases != null && activePermanentNonPrepeatablePurchases.Count > 0
                && newPurchasedProductDTO.IsPermanent)
            {
                throw new AlreadyPurchasedException();
            }

            if (!newPurchasedProductDTO.IsPermanent && newPurchasedProductDTO.IsRepeatable)
            {
                var activeRepeatableTemporaryPurchase = await _purchasedProductRepository
                    .GetRepeatableTemporarytPurchaseByUserNameAsync(user.UserName, product.Id, false);

                if (activeRepeatableTemporaryPurchase != null)
                {
                    var theoreticalExpirationDate = activeRepeatableTemporaryPurchase.LastPurchaseDate
                        .AddMonths(newPurchasedProductDTO.ValidityPeriodInMonths);

                    if (DateTime.Now <= theoreticalExpirationDate)
                    {
                        await ExecutePurchaseForValidityExtendingAsync(
                            activeRepeatableTemporaryPurchase,
                            newPurchasedProductDTO,
                            user,
                            product);

                        return;
                    }
                }
            }

            await ExecutePurchaseAsync(newPurchasedProductDTO, user, product);
        }

        private async Task PurchaseOtherProductAsync(
            NewPurchasedProductDTO newPurchasedProductDTO,
            User user,
            Product product)
        {
            var transaction = _unitOfWork.BeginTransaction();
            try
            {
                user.Currency -= product.PermanentPrice;
                await _unitOfWork.UserRepository.UpdateAsync(user);

                var newPurchasedProduct = _productMapper.MapToPurchasedProduct(newPurchasedProductDTO, product.PermanentPrice);
                var addedPurchase = await _unitOfWork.PurchasedProductRepository.AddAsync(newPurchasedProduct);

                var newState = new PurchaseState()
                {
                    GameServerId = product.GameServerId.Value,
                    PurchasedProductId = addedPurchase.Id
                };

                await _unitOfWork.PurchaseStateRepository.AddAsync(newState);

                transaction.Commit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaction.Rollback();
            }

            transaction.Dispose();
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

                var userRanks = await _unitOfWork.PurchasedProductRepository.GetAllWithExceptingByUserNameAsync(
                    activeRepeatableTemporaryPurchase.Id,
                    user.UserName,
                    true);

                var productOfNewPurchase = await _unitOfWork.ProductRepository.GetByIdAsync(activeRepeatableTemporaryPurchase.ProductId);
                if (productOfNewPurchase.IsRank && userRanks.Count > 0)
                {
                    await OverwriteAllActiveRanksAsync(userRanks);
                }

                if (activeRepeatableTemporaryPurchase.LastPurchaseDate < DateTime.Now)
                {
                    activeRepeatableTemporaryPurchase.ValidityPeriodInMonths += newPurchasedProductDTO.ValidityPeriodInMonths;
                }
                else
                {
                    activeRepeatableTemporaryPurchase.LastPurchaseDate = DateTime.Now;
                    activeRepeatableTemporaryPurchase.ValidityPeriodInMonths = newPurchasedProductDTO.ValidityPeriodInMonths;
                }

                await ResetActivationFlagsAsync(activeRepeatableTemporaryPurchase.Id, false);
                await ResetExpirationFlagsAsync(activeRepeatableTemporaryPurchase.Id, false);
                activeRepeatableTemporaryPurchase.IsOverwrittenByOtherRank = false;

                await _unitOfWork.PurchasedProductRepository.UpdateAsync(activeRepeatableTemporaryPurchase);

                transaction.Commit();
            }
            catch (Exception e)
            {
                transaction.Rollback();
                transaction.Dispose();
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

                int price;
                if (newPurchasedProductDTO.IsPermanent)
                {
                    price = product.PermanentPrice;
                }
                else
                {
                    price = product.PricePerMonth * newPurchasedProductDTO.ValidityPeriodInMonths;
                }
                
                var purchasedProduct = _productMapper.MapToPurchasedProduct(newPurchasedProductDTO, price);
                var productOfNewPurchase = await _unitOfWork.ProductRepository.GetByIdAsync(purchasedProduct.ProductId);
                var addedPurchasedProduct = await _unitOfWork.PurchasedProductRepository.AddAsync(purchasedProduct);

                var userRanks = await _unitOfWork.PurchasedProductRepository.GetAllWithExceptingByUserNameAsync(
                    addedPurchasedProduct.Id,
                    user.UserName,
                    true);

                if (productOfNewPurchase.IsRank && userRanks.Count > 0)
                {
                    await OverwriteAllActiveRanksAsync(userRanks);
                }

                var addedStates = await _unitOfWork.PurchaseStateRepository.AddNewStateForEveryGameServersAsync(new PurchaseState()
                {
                    IsActivationVerified = false,
                    IsExpirationVerified = false,
                    PurchasedProduct = addedPurchasedProduct,
                    PurchasedProductId = addedPurchasedProduct.Id
                });

                transaction.Commit();
            }
            catch (Exception e)
            {
                transaction.Rollback();
                transaction.Dispose();
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
                    await _unitOfWork.UserRepository.UpdateAsync(user);
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
                    await _unitOfWork.UserRepository.UpdateAsync(user);
                }
            }

            return true;
        }

        private async Task OverwriteAllActiveRanksAsync(IList<PurchasedProduct> alreadyActivatedRanks)
        {
            foreach (var activeRank in alreadyActivatedRanks)
            {
                activeRank.IsOverwrittenByOtherRank = true;

                await ResetActivationFlagsAsync(activeRank.Id, true);
                await ResetExpirationFlagsAsync(activeRank.Id, true);
                await _purchasedProductRepository.UpdateAsync(activeRank);
            }
        }

        public async Task<bool> ReactivatePermanentRankAsync(ReactivatePermanentRankDTO reactivatePermanentRankDTO)
        {
            var reactivatedRank = await _purchasedProductRepository.GetByIdAsync(reactivatePermanentRankDTO.PermanentPurchaseId);

            if (reactivatedRank != null && reactivatedRank.Product.IsRank && reactivatedRank.IsPermanent)
            {
                var userRanks = await _unitOfWork.PurchasedProductRepository.GetAllWithExceptingByUserNameAsync(
                    reactivatePermanentRankDTO.PermanentPurchaseId,
                    reactivatePermanentRankDTO.UserName,
                    true);

                if (userRanks != null && userRanks.Count > 0)
                {
                    await OverwriteAllActiveRanksAsync(userRanks);
                }

                reactivatedRank.IsOverwrittenByOtherRank = false;

                await ResetActivationFlagsAsync(reactivatedRank.Id, false);
                await ResetExpirationFlagsAsync(reactivatedRank.Id, false);

                await _unitOfWork.PurchasedProductRepository.UpdateAsync(reactivatedRank);
                return true;
            }

            return false;
        }
        
        private async Task ResetActivationFlagsAsync(Guid purchasedProductId, bool flagValue)
        {
            var states = await _purchaseStateRepository.GetByPurchasedProductIdAsync(purchasedProductId);

            foreach (var state in states)
            {
                state.IsActivationVerified = flagValue;
            }

            await _purchaseStateRepository.UpdateRangeAsync(states);
        }

        private async Task ResetExpirationFlagsAsync(Guid purchasedProductId, bool flagValue)
        {
            var states = await _purchaseStateRepository.GetByPurchasedProductIdAsync(purchasedProductId);

            foreach (var state in states)
            {
                state.IsExpirationVerified = flagValue;
            }

            await _purchaseStateRepository.UpdateRangeAsync(states);
        }

        public async Task UpdatePurchasesForNewGameServerAsync(
            string username,
            string password)
        {
            await _userService.VerifyPasswordAsync(username, password);

            var transaction = _unitOfWork.BeginTransaction();
            try
            {
                var rankPurchases = await _unitOfWork.PurchasedProductRepository.GetAllRankPurchasesByTypeAsync(true);
                var runningGameServerIds = await _unitOfWork.GameServerRepository.GetAllIdsAsync();

                foreach (var ranksPurchase in rankPurchases)
                {
                    var states = await _unitOfWork.GameServerRepository.GetAllByPurchasedRankIdAsync(ranksPurchase.Id);

                    if (states == null || states.Count == 0)
                    {
                        continue;
                    }

                    foreach (var runningGameServerId in runningGameServerIds)
                    {
                        if (!states.Select(state => state.GameServerId).Contains(runningGameServerId))
                        {
                            // INFO: runningGameServerId is missing from purchase states
                            var newState = new PurchaseState()
                            {
                                GameServerId = runningGameServerId,
                                PurchasedProductId = ranksPurchase.Id
                            };

                            if (ranksPurchase.IsOverwrittenByOtherRank)
                            {
                                newState.IsActivationVerified = true;
                                newState.IsExpirationVerified = true;
                            }

                            await _unitOfWork.PurchaseStateRepository.AddAsync(newState);
                        }
                    }
                }

                transaction.Commit();
            }
            catch (Exception e)
            {
                transaction.Rollback();
                transaction.Dispose();
                throw e;
            }

            transaction.Dispose();
        }

        public async Task<bool> CreateNewProductAsync(NewProductDTO newProductDTO)
        {
            var newProduct = _productMapper.MapToProduct(newProductDTO);
            var addedValue = await _productRepository.AddAsync(newProduct);

            return addedValue != null;
        }

        public async Task UpdateProductAsync(ProductDTO productDTO) =>
            await _productRepository.UpdateAsync(_productMapper.MapToProduct(productDTO));

        public async Task DeleteProductAsync(Guid productId) =>
            await _productRepository.RemoveAsync(productId);


        public async Task<ProductListDTO> GetAllbyCategoryIdAsync(Guid categoryId)
        {
            var products = await _productRepository.GetAllNonRanksByCategoryIdAsync(categoryId);

            return new ProductListDTO()
            {
                Products = _productMapper.MapAllToProductDTO(products)
            };
        }

        public async Task<CategoryListDTO> GetAllProductCategoriesAsync()
        {
            var categories = await _productRepository.GetAllCategoriesAsync();

            return new CategoryListDTO()
            {
                Categories = _productMapper.MapAllToCategoryDTO(categories)
            };
        }

        public async Task UpdateProductCategoryAsync(CategoryDTO productCategoryDTO)
        {
            var existingCat = await _productCategoryRepository.GetCategoryByIdAsync(productCategoryDTO.CategoryId);

            if (existingCat == null)
            {
                throw new NotFoundException();
            }

            existingCat.CategoryName = productCategoryDTO.CategoryName;
            existingCat.IsUsed = productCategoryDTO.IsUsed;
            existingCat.Priority = productCategoryDTO.Priority;

            await _productCategoryRepository.UpdateAsync(existingCat);
        }

        public async Task AddProductCategoryAsync(NewCategoryDTO productCategoryDTO) =>
            await _productCategoryRepository.AddAsync(
                _productMapper.MapToCategory(productCategoryDTO));

        public async Task DeleteProductCategoryAsync(Guid categoryId)
        {
            var category = await _productCategoryRepository.GetByIdAsync(categoryId);
            if (category == null)
            {
                throw new NotFoundException();
            }

            if (category.Products != null && category.Products.Count > 0)
            {
                throw new InvalidCategoryDeleteException();
            }

            category.IsActive = false;
            await _productCategoryRepository.UpdateAsync(category);
        }
    }
}

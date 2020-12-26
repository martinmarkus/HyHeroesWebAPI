﻿using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Infrastructure.Persistence.UnitOfWork;
using HyHeroesWebAPI.Presentation.ConfigObjects;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mapper.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using SzamlazzHuService.Services;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IUserRepository _userRepository;
        private readonly IBillingTransactionRepository _billingTransactionRepository;
        private readonly IPurchasedProductRepository _purchasedProductRepository;
        private readonly IFailedTransactionRepository _failedTransactionRepository;
        private readonly IGameServerRepository _gameServerRepository;
        private readonly IPurchaseStateRepository _purchaseStateRepository;
        private readonly IProductMapper _productMapper;
        private readonly IBillingMapper _billingMapper;

        private readonly IUserService _userService;

        private readonly BillService _billService;

        private IUnitOfWork _unitOfWork;

        private readonly IOptions<AppSettings> _appSettingsOptions;

        public ProductService(
            IProductRepository productRepository,
            IUserRepository userRepository,
            IBillingTransactionRepository billingTransactionRepository,
            IPurchasedProductRepository purchasedProductRepository,
            IFailedTransactionRepository failedTransactionRepository,
            IPurchaseStateRepository purchaseStateRepository,
            IGameServerRepository gameServerRepository,
            IProductMapper productMapper,
            IBillingMapper billingMapper,
            IUserService userService,
            BillService billService,
            IUnitOfWork unitOfWork,
            IOptions<AppSettings> appSettingsOptions)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _purchasedProductRepository = purchasedProductRepository ?? throw new ArgumentNullException(nameof(purchasedProductRepository));
            _gameServerRepository = gameServerRepository ?? throw new ArgumentNullException(nameof(gameServerRepository));
             _billingTransactionRepository = billingTransactionRepository ?? throw new ArgumentNullException(nameof(billingTransactionRepository));
            _failedTransactionRepository = failedTransactionRepository ?? throw new ArgumentNullException(nameof(failedTransactionRepository));
            _purchaseStateRepository = purchaseStateRepository ?? throw new ArgumentNullException(nameof(purchaseStateRepository));

            _productMapper = productMapper ?? throw new ArgumentNullException(nameof(productMapper));

            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
            _billService = billService ?? throw new ArgumentNullException(nameof(billService));
            _billingMapper = billingMapper ?? throw new ArgumentNullException(nameof(billingMapper));
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));

            _appSettingsOptions = appSettingsOptions ?? throw new ArgumentNullException(nameof(appSettingsOptions));
        }

        public async Task<IList<ProductDTO>> GetAllProductsAsync() =>
            _productMapper.MapAllToProductDTO(
                await _productRepository.GetAllProductsAsync());

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
                await _purchasedProductRepository.GetAllByUserNameAsync(userName, true));

        public async Task<ActualValueOfOneKreditDTO> GetActualValueOfOneKreditAsync()
        {
            var newValue = await _purchasedProductRepository.GetActualValueOfOneKreditAsync();

            return new ActualValueOfOneKreditDTO()
            {
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

            //foreach (var existingPurchase in existingPurchasedProducts)
            //{
            //    foreach (var activateDTO in activatedOnServerDTOs)
            //    {
            //        if (activateDTO.PurchasedProductId != existingPurchase.Id)
            //        {
            //            continue;
            //        }

            //        var serverActivation = await _serverActivationRepository.GetByPurchasedProductIdAsync(existingPurchase.Id);
            //        foreach (PropertyInfo serverActivationProp in serverActivation.GetType().GetProperties())
            //        {
            //            if (serverActivationProp.Name.Equals(activateDTO.ServerName, StringComparison.OrdinalIgnoreCase))
            //            {
            //                serverActivationProp.SetValue(serverActivation, true);
            //                break;
            //            }
            //        }

            //        await _serverActivationRepository.UpdateAsync(serverActivation);

            //        var isAllPropTrue = true;
            //        foreach (PropertyInfo serverActivationProp in serverActivation.GetType().GetProperties())
            //        {
            //            try
            //            {
            //                bool propValue = (bool)serverActivationProp.GetValue(serverActivation);

            //                if (!propValue)
            //                {
            //                    isAllPropTrue = false;
            //                    break;
            //                }
            //            }
            //            catch (Exception e)
            //            {
            //                Console.WriteLine(e.Message);
            //            }
            //        }

            //        if (isAllPropTrue)
            //        {
            //            existingPurchase.IsVerified = true;
            //        }
            //    }
            //}

            //await _purchasedProductRepository.UpdateAllAsync(existingPurchasedProducts);

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
            //foreach (var purchase in existingPurchasedProducts)
            //{
            //    var serverExpiration = await _serverExpirationRepository
            //        .GetByPurchasedProductIdAsync(purchase.Id);

            //    if (serverExpiration == null)
            //    {
            //        continue;
            //    }

            //    foreach (PropertyInfo serverExpirationProp in serverExpiration.GetType().GetProperties())
            //    {
            //        if (serverExpirationProp.Name.Equals(serverName, StringComparison.OrdinalIgnoreCase))
            //        {
            //            serverExpirationProp.SetValue(serverExpiration, true);
            //            break;
            //        }
            //    }
                
            //    await _serverExpirationRepository.UpdateAsync(serverExpiration);

            //    var isAllPropTrue = true;
            //    foreach (PropertyInfo serverExpirationProp in serverExpiration.GetType().GetProperties())
            //    {
            //        try
            //        {
            //            bool propValue = (bool)serverExpirationProp.GetValue(serverExpiration);

            //            if (!propValue)
            //            {
            //                isAllPropTrue = false;
            //                break;
            //            }
            //        }
            //        catch (Exception e)
            //        {
            //            Console.WriteLine(e.Message);
            //        }
            //    }

            //    if (isAllPropTrue)
            //    {
            //        purchase.IsExpirationVerified = true;
            //    }
            //}

            //await _purchasedProductRepository.UpdateAllAsync(existingPurchasedProducts);

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

                if (activeRepeatableTemporaryPurchase.LastPurchaseDate < DateTime.Now)
                {
                    activeRepeatableTemporaryPurchase.ValidityPeriodInMonths += newPurchasedProductDTO.ValidityPeriodInMonths;
                }
                else
                {
                    activeRepeatableTemporaryPurchase.LastPurchaseDate = DateTime.Now;
                    activeRepeatableTemporaryPurchase.ValidityPeriodInMonths = newPurchasedProductDTO.ValidityPeriodInMonths;
                }

                //activeRepeatableTemporaryPurchase.IsExpirationVerified = false;
                //activeRepeatableTemporaryPurchase.IsOverwrittenByOtherRank = false;

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
            PurchasedProduct purchasedProduct = null;
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
                
                purchasedProduct = _productMapper.MapToPurchasedProduct(newPurchasedProductDTO, price);
                //purchasedProduct.IsVerified = false;
                //purchasedProduct.IsExpirationVerified = false;



                var anotherRanks = await _unitOfWork.PurchasedProductRepository.GetAllActivePurchasesByUserNameAsync(user.UserName, true);
                var productOfNewPurchase = await _unitOfWork.ProductRepository.GetByIdAsync(purchasedProduct.ProductId);
                if (productOfNewPurchase.IsRank && anotherRanks.Count > 0)
                {
                    await OverwriteAllActiveRanksAsync(anotherRanks);
                }

                var addedPurchasedProduct = await _unitOfWork.PurchasedProductRepository.AddAsync(purchasedProduct);

                var addedStates = await _unitOfWork.PurchaseStateRepository.AddNewStateForEveryGameServersAsync(new PurchaseState()
                {
                    IsActivationVerified = false,
                    IsExpirationVerified = false,
                    PurchasedProduct = addedPurchasedProduct,
                    PurchasedProductId = addedPurchasedProduct.Id
                });

                // TODO: old activation logic, remove
                //var serverActivation = new ServerActivation()
                //{
                //    //PurchasedProductId = addedPurchasedProduct.Id,
                //    PurchasedProduct = addedPurchasedProduct
                //};
                //await _serverActivationRepository.AddAsync(serverActivation);

                //var serverExpiration = new ServerExpiration()
                //{
                //    //PurchasedProductId = addedPurchasedProduct.Id,
                //    PurchasedProduct = addedPurchasedProduct
                //};
                //await _serverExpirationRepository.AddAsync(serverExpiration);

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

                // INFO: is not needed, because rank overwrite cant modify its state, only the game server
                //activeRank.IsVerified = true;
                //activeRank.IsExpirationVerified = true;

                await ResetActivationFlagsAsync(activeRank.Id, true);
                await ResetExpirationFlagsAsync(activeRank.Id, false);
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
                //reactivatedRank.IsExpirationVerified = false;
                //reactivatedRank.IsVerified = false;

                await ResetActivationFlagsAsync(reactivatedRank.Id, false);
                await ResetExpirationFlagsAsync(reactivatedRank.Id, false);

                await _unitOfWork.PurchasedProductRepository.UpdateAsync(reactivatedRank);
                return true;
            }

            return false;
        }
        
        private async Task ResetActivationFlagsAsync(Guid purchasedProductId, bool value)
        {
            var states = await _purchaseStateRepository.GetByPurchasedProductIdAsync(purchasedProductId);

            foreach (var state in states)
            {
                state.IsActivationVerified = value;
            }

            await _purchaseStateRepository.UpdateRangeAsync(states);

            //var serverActivation = await _serverActivationRepository.GetByPurchasedProductIdAsync(purchasedProductId);

            //serverActivation.Lobby = value;
            //serverActivation.GTA = value;
            //serverActivation.Creative = value;
            //serverActivation.OpSkyBlock = value;
            //serverActivation.PotterCraft = value;
            //serverActivation.Prison = value;
            //serverActivation.SkyBoss = value;
            //serverActivation.Survival = value;
            //serverActivation.ComboFly = value;
            //serverActivation.Arcade = value;

            //await _serverActivationRepository.UpdateAsync(serverActivation);
        }

        private async Task ResetExpirationFlagsAsync(Guid purchasedProductId, bool value)
        {
            var states = await _purchaseStateRepository.GetByPurchasedProductIdAsync(purchasedProductId);

            foreach (var state in states)
            {
                state.IsExpirationVerified = value;
            }

            await _purchaseStateRepository.UpdateRangeAsync(states);

            //var serverExpiration = await _serverExpirationRepository.GetByPurchasedProductIdAsync(purchasedProductId);

            //serverExpiration.Lobby = value;
            //serverExpiration.GTA = value;
            //serverExpiration.Creative = value;
            //serverExpiration.OpSkyBlock = value;
            //serverExpiration.PotterCraft = value;
            //serverExpiration.Prison = value;
            //serverExpiration.SkyBoss = value;
            //serverExpiration.Survival = value;
            //serverExpiration.ComboFly = value;
            //serverExpiration.Arcade = value;

            //await _serverExpirationRepository.UpdateAsync(serverExpiration);
        }

        public async Task UpdatePurchasesForNewGameServerAsync(
            string username,
            string password)
        {
            await _userService.SendEmailVerifyCodeAsync(username, password);

            var purchases = await _purchasedProductRepository.GetAllAsync();
            var runningGameServerIds = await _gameServerRepository.GetAllRunningServerIdsAsync();

            foreach (var purchase in purchases)
            {
                var states = await _gameServerRepository.GetAllByPurchasedRankIdAsync(purchase.Id);

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
                            PurchasedProductId = purchase.Id
                        };

                        if (purchase.IsOverwrittenByOtherRank)
                        {
                            newState.IsActivationVerified = true;
                            newState.IsExpirationVerified = false;
                        }

                        await _purchaseStateRepository.AddAsync(newState);
                    }
                }
            }
        }

        public async Task<bool> CreateNewProductAsync(NewProductDTO newProductDTO)
        {
            var newProduct = _productMapper.MapToProduct(newProductDTO);
            var addedValue = await _productRepository.AddAsync(newProduct);

            return addedValue != null;
        }

        public async Task<bool> UpdateProductAsync(ProductDTO productDTO)
        {
            var product = _productMapper.MapToProduct(productDTO);
            await _productRepository.UpdateAsync(product);

            return true;
        }

        public async Task<bool> DeleteProductAsync(Guid productId)
        {
            await _productRepository.RemoveAsync(productId);
            return true;
        }
    }
}

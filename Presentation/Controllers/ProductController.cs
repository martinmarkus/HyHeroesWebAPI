using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Presentation.Attributes;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Filters;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Controllers
{
    [ControllerName("Products")]
    public class ProductController : AuthorizableBaseController
    {
        private readonly IProductService _productService;

        public ProductController(
            IProductService productService,
            IUserService userService,
            IAuthorizerService authorizerService)
            : base(userService, authorizerService)
        {
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
        }

        [RequiredRole("User")]
        [ExceptionHandler]
        [HttpGet("GetAllProducts", Name = "getAllProducts")]
        [ProducesResponseType(typeof(IList<ProductDTO>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetAllProducts()
        {
            try
            {
                var products = await _productService.GetAllProductsAsync();

                return Ok(products);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [RequiredRole("User")]
        [ExceptionHandler]
        [HttpPost("AddPurchase", Name = "addPurchase")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> AddPurchase([FromBody]NewPurchasedProductDTO newPurchasedProductDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                await _productService.PurchaseProductAsync(newPurchasedProductDTO);

                return Ok(new EmptyDTO());
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [RequiredRole("Admin")]
        [ExceptionHandler]
        [HttpGet("GetUnverifiedPurchases", Name = "getUnverifiedPurchases")]
        [ProducesResponseType(typeof(IList<PurchasedProductDTO>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetUnverifiedPurchases()
        {
            try
            {
                var purchasedProducts = await _productService.GetAllUnverifiedPurchasedProductsAsync();

                return Ok(purchasedProducts);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [RequiredRole("Admin")]
        [ExceptionHandler]
        [HttpPost("VerifyPurchases", Name = "verifyPurchases")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> VerifyPurchases([FromBody] IList<Guid> purchasedProductIds)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                var isSuccessfullyVerified = await _productService.VerifyPurchasedProductsAsync(purchasedProductIds);
                if (isSuccessfullyVerified)
                {
                    return Ok(new EmptyDTO());
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return BadRequest();
        }

        [RequiredRole("Admin")]
        [ExceptionHandler]
        [HttpGet("GetUnverifiedExpiredProducts", Name = "getUnverifiedExpiredProducts")]
        [ProducesResponseType(typeof(IList<PurchasedProductDTO>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetUnverifiedExpiredProducts()
        {
            try
            {
                var expiredPurchasedProducts = await _productService.GetUnverifiedExpiredPurchasedProductsAsync();

                return Ok(expiredPurchasedProducts);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [RequiredRole("Admin")]
        [ExceptionHandler]
        [HttpPost("VerifyExpiredProducts", Name = "verifyExpiredProducts")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> VerifyExpiredProducts([FromBody] IList<Guid> purchasedProductIds)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                var isExpirationVerified = await _productService.VerifyExpiredProductsAsync(purchasedProductIds);
                if (isExpirationVerified)
                {
                    return Ok(new EmptyDTO());
                }

            }
            catch (Exception e)
            {
                throw e;
            }

            return BadRequest();
        }

        [RequiredRole("Admin")]
        [ExceptionHandler]
        [HttpGet("GetActivePurchases/{userName}", Name = "getActivePurchases")]
        [ProducesResponseType(typeof(IList<PurchasedProductDTO>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetActivePurchases([FromRoute] string userName)
        {
            try
            {
                var result = await _productService.GetAllActivePurchasesByUserNameAsync(userName);
                return Ok(result);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [RequiredRole("User")]
        [ExceptionHandler]
        [HttpGet("GetOwnActivePurchases", Name = "getOwnActivePurchases")]
        [ProducesResponseType(typeof(IList<PurchasedProductDTO>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetOwnActivePurchases()
        {
            try
            {
                return Ok(await _productService.GetAllActivePurchasesByUserEmailAsync(
                    User.FindFirstValue(ClaimTypes.Name)));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [RequiredRole("Admin")]
        [ExceptionHandler]
        [HttpGet("GetVerifiedPurchases", Name = "getVerifiedPurchases")]
        [ProducesResponseType(typeof(IList<PurchasedProductDTO>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetVerifiedPurchases()
        {
            try
            {
                var purchasedProducts = await _productService.GetAllVerifiedPurchasedProductsAsync();

                return Ok(purchasedProducts);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [RequiredRole("Admin")]
        [ExceptionHandler]
        [HttpPost("VerifyPurchase/{purchasedProductId}", Name = "verifyPurchase")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> VerifyPurchase([FromRoute] Guid purchasedProductId)
        {
            try
            {
                var isSuccessfullyVerified = await _productService.VerifyPurchasedProductAsync(purchasedProductId);
                if (isSuccessfullyVerified)
                {
                    return Ok(new EmptyDTO());
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return BadRequest();
        }

        [RequiredRole("Admin")]
        [ExceptionHandler]
        [HttpGet("GetAllExpiredProducts", Name = "getAllExpiredProducts")]
        [ProducesResponseType(typeof(IList<PurchasedProductDTO>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetAllExpiredProducts()
        {
            try
            {
                var expiredPurchasedProducts = await _productService.GetAllExpiredPurchasedProductsAsync();

                return Ok(expiredPurchasedProducts);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [RequiredRole("Admin")]
        [ExceptionHandler]
        [HttpPost("VerifyExpiredProduct/{purchasedProductId}", Name = "verifyExpiredProduct")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> VerifyExpiredProduct([FromRoute] Guid purchasedProductId)
        {
            try
            {
                var isExpirationVerified = await _productService.VerifyExpiredProductAsync(purchasedProductId);
                if (isExpirationVerified)
                {
                    return Ok(new EmptyDTO());
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return BadRequest();
        }

        [RequiredRole("User")]
        [ExceptionHandler]
        [HttpGet("GetActualValueOfOneKredit", Name = "getActualValueOfOneKredit")]
        [ProducesResponseType(typeof(ActualValueOfOneKredit), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetActualValueOfOneKredit()
        {
            try
            {
                var actualValueOfOneKredit = await _productService.GetActualValueOfOneKreditAsync();
                if (actualValueOfOneKredit != null)
                {
                    return Ok(actualValueOfOneKredit);
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return BadRequest();
        }

        [RequiredRole("Admin")]
        [ExceptionHandler]
        [HttpPost("SetActualValueOfOneKredit", Name = "setActualValueOfOneKredit")]
        [ProducesResponseType(typeof(ActualValueOfOneKreditDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> SetActualValueOfOneKredit([FromBody] ActualValueOfOneKreditDTO actualValueOfOneKredit)
        {
            try
            {
                var newValue = await _productService.SetActualValueOfOneKreditAsync(actualValueOfOneKredit);
                if (newValue != null)
                {
                    return Ok(newValue);
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return BadRequest();
        }

        [RequiredRole("User")]
        [ExceptionHandler]
        [HttpPost("ReactivatePermanentRank", Name = "reactivatePermanentRank")]
        [ProducesResponseType(typeof(ReactivatePermanentRankDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> ReactivatePermanentRank([FromBody] ReactivatePermanentRankDTO reactivatePermanentRankDTO)
        {
            try
            {
                var isReactivated = await _productService.ReactivatePermanentRankAsync(reactivatePermanentRankDTO);
                if (isReactivated)
                {
                    return Ok(new EmptyDTO());
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return BadRequest();
        }
    }
}

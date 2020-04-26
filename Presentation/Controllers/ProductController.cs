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
    public class ProductController : AuthorizableControllerBase
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
        [HttpGet("GetAllProducts", Name = "getAllProducts")]
        [ProducesResponseType(typeof(IList<ProductDTO>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _productService.GetAllProductsAsync();

            return Ok(products);
        }

        [RequiredRole("Admin")]
        [HttpGet("GetUnverifiedPurchases", Name = "getUnverifiedPurchases")]
        [ProducesResponseType(typeof(IList<PurchasedProductDTO>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetUnverifiedPurchases()
        {
            var purchasedProducts = await _productService.GetAllUnverifiedPurchasedProductsAsync();

            return Ok(purchasedProducts);
        }

        [RequiredRole("Admin")]
        [HttpGet("GetVerifiedPurchases", Name = "getVerifiedPurchases")]
        [ProducesResponseType(typeof(IList<PurchasedProductDTO>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetVerifiedPurchases()
        {
            var purchasedProducts = await _productService.GetAllVerifiedPurchasedProductsAsync();

            return Ok(purchasedProducts);
        }

        [RequiredRole("Admin")]
        [HttpPost("VerifyPurchasedProduct/{purchasedProductId}", Name = "verifyPurchasedProduct")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> VerifyPurchasedProduct([FromRoute] Guid purchasedProductId)
        {
            var isSuccessfullyVerified = await _productService.VerifyPurchasedProductAsync(purchasedProductId);
            if (isSuccessfullyVerified)
            {
                return Ok();
            }
            
            return BadRequest();
        }

        [RequiredRole("Admin")]
        [HttpPost("VerifyPurchasedProducts", Name = "verifyPurchasedProducts")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> VerifyPurchasedProducts([FromBody] IList<Guid> purchasedProductIds)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var isSuccessfullyVerified = await _productService.VerifyPurchasedProductsAsync(purchasedProductIds);
            if (isSuccessfullyVerified)
            {
                return Ok();
            }
            
            return BadRequest();
        }

        [RequiredRole("Admin")]
        [HttpGet("GetUnverifiedExpiredProducts", Name = "getUnverifiedExpiredProducts")]
        [ProducesResponseType(typeof(IList<PurchasedProductDTO>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetUnverifiedExpiredProducts()
        {
            var expiredPurchasedProducts = await _productService.GetUnverifiedExpiredPurchasedProductsAsync();

            return Ok(expiredPurchasedProducts);
        }

        [RequiredRole("Admin")]
        [HttpGet("GetAllExpiredProducts", Name = "getAllExpiredProducts")]
        [ProducesResponseType(typeof(IList<PurchasedProductDTO>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetAllExpiredProducts()
        {
            var expiredPurchasedProducts = await _productService.GetAllExpiredPurchasedProductsAsync();

            return Ok(expiredPurchasedProducts);
        }

        [RequiredRole("Admin")]
        [HttpPost("VerifyExpiredProduct/{purchasedProductId}", Name = "verifyExpiredProduct")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> VerifyExpiredProduct([FromRoute] Guid purchasedProductId)
        {
            var isExpirationVerified = await _productService.VerifyExpiredProductAsync(purchasedProductId);
            if (isExpirationVerified)
            {
                return Ok();
            }
            
            return BadRequest();
        }

        [RequiredRole("Admin")]
        [HttpPost("VerifyExpiredProducts", Name = "verifyExpiredProducts")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> VerifyExpiredProducts([FromBody] IList<Guid> purchasedProductIds)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var isExpirationVerified = await _productService.VerifyExpiredProductsAsync(purchasedProductIds);
            if (isExpirationVerified)
            {
                return Ok();
            }

            return BadRequest();
        }

        [HttpPost("AddPurchasedProduct", Name = "addPurchasedProduct")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> AddPurchasedProduct([FromBody]NewPurchasedProductDTO newPurchasedProductDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            await _productService.AddPurchasedProductAsync(newPurchasedProductDTO);

            return Ok();
        }

        [RequiredRole("User")]
        [HttpGet("GetUserPurchases/{userId}", Name = "getUserPurchases")]
        [ProducesResponseType(typeof(IList<PurchasedProductDTO>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetUserPurchases([FromRoute] Guid userId)
        {
            var email = User.FindFirstValue(ClaimTypes.Name);
            var isSelf = await AuthorizerService.IsSelfAsync(email, userId);

            if (isSelf || IsAuthenticatedAdmin)
            {
                return Ok(await _productService.GetPurchasesByUserIdAsync(userId));
            }

            return Forbid();
        }
    }
}

using HyHeroesWebAPI.Presentation.Attributes;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Controllers
{
    [ControllerName("Products")]
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
        }

        [HttpGet("GetAllProducts", Name = "getAllProducts")]
        [ProducesResponseType(typeof(IList<ProductDTO>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _productService.GetAllProductsAsync();

            return Ok(products);
        }

        [HttpGet("GetUnverifiedPurchases", Name = "getUnverifiedPurchases")]
        [ProducesResponseType(typeof(IList<PurchasedProductDTO>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetUnverifiedPurchases()
        {
            var purchasedProducts = await _productService.GetAllUnverifiedPurchasedProductsAsync();

            return Ok(purchasedProducts);
        }

        [HttpGet("GetVerifiedPurchases", Name = "getVerifiedPurchases")]
        [ProducesResponseType(typeof(IList<PurchasedProductDTO>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetVerifiedPurchases()
        {
            var purchasedProducts = await _productService.GetAllVerifiedPurchasedProductsAsync();

            return Ok(purchasedProducts);
        }

        [HttpPost("VerifyPurchasedProduct", Name = "verifyPurchasedProduct")]
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
            else
            {
                return BadRequest();
            }
        }

        [HttpPost("VerifyPurchasedProducts", Name = "verifyPurchasedProducts")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> VerifyPurchasedProducts([FromBody] IList<Guid> purchasedProductIds)
        {
            var isSuccessfullyVerified = await _productService.VerifyPurchasedProductsAsync(purchasedProductIds);

            if (isSuccessfullyVerified)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("GetExpiredProducts", Name = "getExpiredProducts")]
        [ProducesResponseType(typeof(IList<PurchasedProductDTO>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetExpiredProducts()
        {
            var expiredPurchasedProducts = await _productService.GetExpiredPurchasedProductsAsync();

            return Ok(expiredPurchasedProducts);
        }

        [HttpGet("VerifyPurchaseExpiration", Name = "verifyPurchaseExpiration")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> VerifyPurchaseExpiration()
        {
            //var expiredPurchasedProducts = await _productService.VerifyPurchaseExpiration();

            return Ok();
        }
    }
}

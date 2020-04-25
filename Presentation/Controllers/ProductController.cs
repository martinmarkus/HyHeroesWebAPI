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
            var products = await _productService.GetAllProducts();

            return Ok(products);
        }

        [HttpGet("GetUnverifiedPurchases", Name = "getUnverifiedPurchases")]
        [ProducesResponseType(typeof(IList<PurchasedProductDTO>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetUnverifiedPurchases()
        {
            var purchasedProducts = await _productService.GetAllUnverifiedPurchasedProducts();

            return Ok(purchasedProducts);
        }

        [HttpGet("GetVerifiedPurchases", Name = "getVerifiedPurchases")]
        [ProducesResponseType(typeof(IList<PurchasedProductDTO>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetVerifiedPurchases()
        {
            var purchasedProducts = await _productService.GetAllVerifiedPurchasedProducts();

            return Ok(purchasedProducts);
        }

        [HttpPost("VerifyPurchasedProduct", Name = "verifyPurchasedProduct")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> VerifyPurchasedProduct([FromRoute] Guid purchasedProductId)
        {
            var isSuccessfullyVerified = await _productService.VerifyPurchasedProduct(purchasedProductId);

            if (isSuccessfullyVerified)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut("VerifyPurchasedProducts", Name = "verifyPurchasedProducts")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> VerifyPurchasedProducts([FromBody] IList<Guid> purchasedProductIds)
        {
            var isSuccessfullyVerified = await _productService.VerifyPurchasedProducts(purchasedProductIds);

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
            var expiredPurchasedProducts = await _productService.GetExpiredPurchasedProducts();

            return Ok(expiredPurchasedProducts);
        }
    }
}

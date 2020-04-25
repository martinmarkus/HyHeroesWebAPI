using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
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
        private readonly IPurchasedProductRepository _purchasedProductRepository;

        public ProductController(
            IProductService productService,
            IPurchasedProductRepository purchasedProductRepository)
        {
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
            _purchasedProductRepository = purchasedProductRepository ?? throw new ArgumentNullException(nameof(purchasedProductRepository));
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
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

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

        [HttpGet("GetUnverifiedExpiredProducts", Name = "getUnverifiedExpiredProducts")]
        [ProducesResponseType(typeof(IList<PurchasedProductDTO>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetUnverifiedExpiredProducts()
        {
            var expiredPurchasedProducts = await _productService.GetUnverifiedExpiredPurchasedProductsAsync();

            return Ok(expiredPurchasedProducts);
        }


        [HttpGet("GetAllExpiredProducts", Name = "getAllExpiredProducts")]
        [ProducesResponseType(typeof(IList<PurchasedProductDTO>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetAllExpiredProducts()
        {
            var expiredPurchasedProducts = await _productService.GetAllExpiredPurchasedProductsAsync();

            return Ok(expiredPurchasedProducts);
        }

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
            else
            {
                return BadRequest();
            }
        }

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
            else
            {
                return BadRequest();
            }
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

            // TODO: validate, that the user has enough money

            await _productService.AddPurchasedProductAsync(newPurchasedProductDTO);

            return Ok();
        }

        [HttpPost("UploadKredit", Name = "uploadKredit")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> UploadKredit([FromBody]KreditUploadDTO kreditUploadDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}

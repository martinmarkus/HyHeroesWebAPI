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
        [HttpGet("GetUnverifiedPurchases/{serverId}", Name = "getUnverifiedPurchases")]
        [ProducesResponseType(typeof(IList<PurchasedProductDTO>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetUnverifiedPurchases(Guid serverId)
        {
            try
            {
                var purchasedProducts = await _productService.GetAllUnverifiedPurchasedProductsAsync(serverId);

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
        public async Task<IActionResult> VerifyPurchases([FromBody] ActivatedPurchasesOnServerDTO activationsDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                var isSuccessfullyVerified = await _productService
                    .VerifyPurchasedProductsAsync(activationsDTO);

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
        [HttpGet("GetUnverifiedExpiredProducts/{serverId}", Name = "getUnverifiedExpiredProducts")]
        [ProducesResponseType(typeof(IList<PurchasedProductDTO>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetUnverifiedExpiredProducts([FromRoute] Guid serverId)
        {
            try
            {
                var expiredPurchasedProducts = await _productService
                    .GetUnverifiedExpiredPurchasedProductsAsync(serverId);

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
        public async Task<IActionResult> VerifyExpiredProducts(
            [FromBody] ExpiredProductsVerificationDTO expiredServerDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                var isExpirationVerified = await _productService
                    .VerifyExpiredProductsAsync(expiredServerDTO);

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
        [HttpGet("GetOwnPurchases", Name = "getOwnPurchases")]
        [ProducesResponseType(typeof(IList<PurchasedProductDTO>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetOwnPurchases()
        {
            try
            {
                return Ok(await _productService.GetAllByUserNameAsync(
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
        [HttpPost("UpdatePurchasesForNewGameServer", Name = "updatePurchasesForNewGameServer")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> UpdatePurchasesForNewGameServerAsync(VerifyPasswordDTO verifyPasswordDTO)
        {
            try
            {
                await _productService.UpdatePurchasesForNewGameServerAsync(
                    User.FindFirstValue(ClaimTypes.Name),
                    verifyPasswordDTO.Password);

                return Ok(new EmptyDTO());
            }
            catch (Exception e)
            {
                throw e;
            }
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
        [ProducesResponseType(typeof(EmptyDTO), 200)]
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

        [RequiredRole("Admin")]
        [ExceptionHandler]
        [HttpPost("CreateProduct", Name = "createProduct")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> CreateProduct([FromBody] NewProductDTO newProductDTO)
        {
            try
            {
                var isCreated = await _productService.CreateNewProductAsync(newProductDTO);
                if (isCreated)
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
        [HttpPut("UpdateProduct", Name = "updateProduct")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> UpdateProduct([FromBody] ProductDTO productDTO)
        {
            try
            {
                var isUpdated = await _productService.UpdateProductAsync(productDTO);
                if (isUpdated)
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
        [HttpDelete("DeleteProduct/{ProductId}", Name = "deleteProduct")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> DeleteProduct([FromRoute] Guid productId)
        {
            try
            {
                var isDeleted = await _productService.DeleteProductAsync(productId);
                if (isDeleted)
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
        [HttpGet("GetAllByCategory/{categoryId}", Name = "getAllByCategory")]
        [ProducesResponseType(typeof(ProductListDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetAllByCategoryAsync([FromRoute] Guid categoryId)
        {
            try
            {
                return Ok(await _productService.GetAllbyCategoryIdAsync(categoryId));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [RequiredRole("User")]
        [ExceptionHandler]
        [HttpGet("GetAllProductCategories", Name = "getAllProductCategories")]
        [ProducesResponseType(typeof(CategoryListDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetAllProductCategoriesAsync()
        {
            try
            {
                return Ok(await _productService.GetAllProductCategoriesAsync());
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [RequiredRole("Admin")]
        [ExceptionHandler]
        [HttpPost("UpdateProductCategory", Name = "updateProductCategory")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> UpdateProductCategoryaSYNC(CategoryDTO productCategoryDTO)
        {
            try
            {
                await _productService.UpdateProductCategoryAsync(productCategoryDTO);
                return Ok(new EmptyDTO());
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [RequiredRole("Admin")]
        [ExceptionHandler]
        [HttpPost("AddProductCategory", Name = "addProductCategory")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> UpdateProductCategoryaSYNC(NewCategoryDTO newCategoryDTO)
        {
            try
            {
                await _productService.AddProductCategoryAsync(newCategoryDTO);
                return Ok(new EmptyDTO());
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

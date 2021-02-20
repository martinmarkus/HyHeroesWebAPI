using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;
using HyHeroesWebAPI.Presentation.ConfigObjects;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Filters;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace HyHeroesWebAPI.Presentation.Controllers
{
    [ValidateIP]
    [ServiceFilter(typeof(SessionRefresh))]
    [ValidateCustomAntiforgery]
    [Route("[controller]")]
    public class AdminController : AuthorizableBaseController
    {
        private readonly IAdminService _adminService;
        private readonly IProductService _productService;
        private readonly IBankTransferService _bankTransferService;
        private readonly INotificationService _notificationService;
        public AdminController(
            IUserService userService,
            IAuthorizerService authorizerService,
            IAdminService adminService,
            IProductService productService,
            IIPValidatorService IPValidatorService,
            ICustomAntiforgeryService customAntiforgeryService,
            IBankTransferService bankTransferService,
            INotificationService notificationService,
            IOptions<AppSettings> appSettings)
            : base(userService, authorizerService, IPValidatorService, customAntiforgeryService, appSettings)
        {
            _bankTransferService = bankTransferService ?? throw new ArgumentException(nameof(bankTransferService));
            _adminService = adminService ?? throw new ArgumentException(nameof(adminService));
            _productService = productService ?? throw new ArgumentException(nameof(productService));
            _notificationService = notificationService ?? throw new ArgumentException(nameof(notificationService));
        }

        [RequiredRole("Admin")]
        [HttpGet("GetGameServerList", Name = "getGameServerList")]
        [ProducesResponseType(typeof(GameServerListDTO), 200)]
        public async Task<IActionResult> GetGameServerListAsync()
        {
            try
            {
                var gameServers = await _adminService.GetAllGameServersAsync();

                if (gameServers != null)
                {
                    return Ok(gameServers);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return BadRequest();
        }

        [RequiredRole("Admin")]
        [HttpPost("UpdateGameServer", Name = "updateGameServer")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        public async Task<IActionResult> UpdateGameServerAsync([FromBody] GameServerDTO gameServerDTO)
        {
            try
            {
                await _adminService.UpdateGameServerAsync(gameServerDTO);

                return Ok(new EmptyDTO());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return BadRequest();
        }

        [RequiredRole("Admin")]
        [HttpPost("DeleteGameServer/{serverId}", Name = "deleteGameServer")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        public async Task<IActionResult> DeleteGameServerAsync([FromRoute][Required] Guid serverId)
        {
            try
            {
                await _adminService.DeleteGameServerAsync(serverId);

                return Ok(new EmptyDTO());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return BadRequest();
        }

        [RequiredRole("Admin")]
        [HttpPost("AddNewGameServer", Name = "addNewGameServer")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        public async Task<IActionResult> AddNewGameServerAsync([FromBody] NewGameServerDTO newGameServerDTO)
        {
            try
            {
                await _adminService.AddGameServerAsync(newGameServerDTO.ServerName);

                return Ok(new EmptyDTO());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return BadRequest();
        }

        [RequiredRole("Admin")]
        [HttpPost("UpdatePurchasesForNewGameServer", Name = "updatePurchasesForNewGameServer")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
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

        [RequiredRole("Admin")]
        [HttpGet("GetBankTransferTransactions/{userNameOrTransferCode}", Name = "getBankTransferTransactions")]
        [ProducesResponseType(typeof(BankTransferListDTO), 200)]
        public async Task<IActionResult> GetBankTransferTransactionsAsync([FromRoute][Required] string userNameOrTransferCode)
        {
            try
            {
                return Ok(await _bankTransferService.GetBankTransferTransactionsAsync(userNameOrTransferCode));
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Presentation.ConfigObjects;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Filters;
using HyHeroesWebAPI.Presentation.Mapper.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace HyHeroesWebAPI.Presentation.Controllers
{
    [Route("[controller]")]
    public class AdminController : AuthorizableBaseController
    {
        private readonly IOptions<AppSettings> _options;
        private readonly IAdminService _adminService;

        public AdminController(
            IOptions<AppSettings> options,
            IUserService userService,
            IAuthorizerService authorizationService,
            IAdminService adminService)
            : base(userService, authorizationService)
        {
            _options = options ?? throw new ArgumentException(nameof(options));
            _adminService = adminService ?? throw new ArgumentException(nameof(adminService));
        }

        [RequiredRole("Admin")]
        [ExceptionHandler]
        [HttpGet("GetGameServerList", Name = "getGameServerList")]
        [ProducesResponseType(typeof(GameServerListDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
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
        [ExceptionHandler]
        [HttpPost("UpdateGameServer", Name = "updateGameServer")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
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
        [ExceptionHandler]
        [HttpPost("DeleteGameServer/{serverId}", Name = "deleteGameServer")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
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
        [ExceptionHandler]
        [HttpPost("AddNewGameServer", Name = "addNewGameServer")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
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
    }
}

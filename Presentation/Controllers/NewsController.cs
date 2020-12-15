using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Filters;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Controllers
{
    [Route("[controller]")]
    public class NewsController : AuthorizableBaseController
    {
        private readonly INewsService _newsService;

        public NewsController(
            IUserService userService,
            IAuthorizerService authorizerService,
            INewsService newsService)
            : base(userService, authorizerService)
        {
            _newsService = newsService ?? throw new ArgumentException(nameof(newsService));
        }

        [AllowAnonymous]
        [ExceptionHandler]
        [HttpGet("GetNews", Name = "getNews")]
        [ProducesResponseType(typeof(NewsDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetNews()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                return Ok(await _newsService.GetNewsAsync(5));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [RequiredRole("Admin")]
        [ExceptionHandler]
        [HttpPost("AddNews", Name = "addNews")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> AddLastestNews([FromBody] LatestNewsDTO latestNewsDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                var publisherUser = await UserService.GetByUserNameAsync(
                     User.FindFirstValue(ClaimTypes.Name));

                await _newsService.AddLatestNewsAsnyc(latestNewsDTO, publisherUser);

                return Ok();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

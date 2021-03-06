using HyHeroesWebAPI.Presentation.DTOs.WebsiteDTOs;
using HyHeroesWebAPI.Presentation.Mappers.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class HomeService : IHomeService
    {
        private readonly INewsService _newsService;
        private readonly IStatisticService _statisticService;
        private readonly IUserService _userService;

        private readonly IHomeMapper _homeMapper;
        private readonly IUserMapper _userMapper;

        public HomeService(
            INewsService newsService,
            IStatisticService statisticService,
            IUserService userService,
            IHomeMapper homeMapper, 
            IUserMapper userMapper)
        {
            _newsService = newsService ?? throw new ArgumentException(nameof(newsService));
            _statisticService = statisticService ?? throw new ArgumentException(nameof(statisticService));
            _userService = userService ?? throw new ArgumentException(nameof(userService));
            
            _homeMapper = homeMapper ?? throw new ArgumentException(nameof(homeMapper));
            _userMapper = userMapper ?? throw new ArgumentException(nameof(userMapper));
        }

        public async Task<HomeDTO> GetHomeContentAsync(string userName)
        {
            var user = await _userService.GetByUserNameAsync(userName);
            var authedUser = _userMapper.MapToAuthenticatedUserDTO(user);

            var news = await _newsService.GetNewsAsync(5);
            var lastPurchases = await _statisticService.GetLastPurchaseStatsAsync(5);

            return _homeMapper.MapToHomeDTO(authedUser, news, lastPurchases);
        }
    }
}

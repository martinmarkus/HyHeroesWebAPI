using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Presentation.Mappers.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using HyHeroesWebAPI.Presentation.DTOs.NewsDTOs;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class NewsService : INewsService
    {
        private readonly INewsRepository _newsRepository;
        private readonly INewsMapper _newsMapper;
        private readonly IDiscordService _discordService;

        public NewsService(
            IDiscordService discordService,
            INewsRepository newsRepository,
            INewsMapper newsMapper)
        {
            _discordService = discordService ?? throw new ArgumentException(nameof(discordService));
            _newsRepository = newsRepository ?? throw new ArgumentException(nameof(newsRepository));
            _newsMapper = newsMapper ?? throw new ArgumentException(nameof(newsMapper));
        }

        public async Task<IList<NewsDTO>> GetNewsAsync(int amount) =>
            _newsMapper.MapToNewsDTO(
                await _newsRepository.GetLatestNewsAsync(amount));

        public async Task AddLatestNewsAsnyc(LatestNewsDTO latestNewsDTO, User publisherUser)
        {
            var addedNews = await _newsRepository.AddAsync(new News()
            {
                Title = latestNewsDTO.Title,
                Preview = latestNewsDTO.Preview,
                FormattedNews = latestNewsDTO.FormattedValue,
                PublisherUser = publisherUser,
                PublisherUserId = publisherUser.Id
            });

            var newsRaw = addedNews.Title + " | "
                + addedNews.CreationDate.ToString("yyyy. MM. dd. HH:mm") + " | "
                + publisherUser.UserName + "\n\n"
                + addedNews.FormattedNews;

            await _discordService.SendMessageToNewsAsync(newsRaw);
        }

        public async Task<NewsDTO> GetNewsByIdAsync(Guid id) =>
            _newsMapper.MapToNewsDTO(await _newsRepository.GetByIdAsync(id));
    }
}

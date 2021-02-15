using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mappers.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class NewsService : INewsService
    {
        private readonly INewsRepository _newsRepository;
        private readonly INewsMapper _newsMapper;

        public NewsService(
            INewsRepository newsRepository,
            INewsMapper newsMapper)
        {
            _newsRepository = newsRepository ?? throw new ArgumentException(nameof(newsRepository));
            _newsMapper = newsMapper ?? throw new ArgumentException(nameof(newsMapper));
        }

        public async Task<IList<NewsDTO>> GetNewsAsync(int amount) =>
            _newsMapper.MapToNewsDTO(
                await _newsRepository.GetLatestNewsAsync(amount));

        public async Task AddLatestNewsAsnyc(LatestNewsDTO latestNewsDTO, User publisherUser) =>
            await _newsRepository.AddAsync(new News()
            {
                Title = latestNewsDTO.Title,
                Preview = latestNewsDTO.Preview,
                FormattedNews = latestNewsDTO.FormattedValue,
                PublisherUser = publisherUser,
                PublisherUserId = publisherUser.Id
            });

    }
}

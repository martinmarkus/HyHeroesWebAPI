using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mappers.Interfaces;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.Mappers
{
    public class NewsMapper : INewsMapper
    {
        public IList<NewsDTO> MapToNewsDTO(IList<News> newsList)
        {
            var newsListDTO = new List<NewsDTO>();

            foreach(var news in newsList)
            {
                newsListDTO.Add(MapToNewsDTO(news));
            }

            return newsListDTO;
        }

        public NewsDTO MapToNewsDTO(News news) =>
            new NewsDTO()
            {
                Title = news.Title,
                Preview = news.Preview,
                FormattedNews = news.FormattedNews,
                PublishDate = news.CreationDate.ToString("yyyy. MM. dd. HH:mm"),
                PublisherName = news.PublisherUser.UserName,
                Id = news.Id
            };
    }
}

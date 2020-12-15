using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.Mapper
{
    public class NewsMapper : INewsMapper
    {
        public IList<NewsDTO> MapToNewsDTO(IList<News> newsList)
        {
            var newsListDTO = new List<NewsDTO>();

            foreach(var news in newsList)
            {
                newsListDTO.Add(new NewsDTO()
                {
                    Title = news.Title,
                    Preview = news.Preview,
                    FormattedNews = news.FormattedNews,
                    PublishDate = news.PublishDate,
                    PublisherName = news.PublisherUser.UserName
                });
            }

            return newsListDTO;
        }
    }
}

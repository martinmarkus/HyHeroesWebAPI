using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs;

namespace HyHeroesWebAPI.Presentation.Mapper
{
    public class NewsMapper : INewsMapper
    {
        public NewsDTO MapToNewsDTO(News news) =>
            new NewsDTO()
            {
                FormattedNews = news.FormattedNews,
                PublishDate = news.PublishDate,
                PublisherName = news.PublisherUser.UserName
            };
    }
}

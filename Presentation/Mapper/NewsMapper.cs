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
                var newsDTO = new NewsDTO();
                
                //if (news.Title.Length > 100)
                //{
                //    newsDTO.Title = news.Title.Substring(0, 100) + " [...]";
                //}
                //else
                //{
                //    newsDTO.Title = news.Title;
                //}

                //if (!string.IsNullOrEmpty(news.Preview) && news.Preview.Length > 300)
                //{
                //    newsDTO.Preview = news.Preview.Substring(0, 300) + " [...]";
                //}
                //else
                //{
                //    newsDTO.Preview = news.Preview;
                //}
                newsDTO.Title = news.Title;

                newsDTO.Preview = news.Preview;
                newsDTO.FormattedNews = news.FormattedNews;
                newsDTO.PublishDate = news.PublishDate.ToString("yyyy/mm/dd. HH:mm");
                newsDTO.PublisherName = news.PublisherUser.UserName;

                newsListDTO.Add(newsDTO);
            }

            return newsListDTO;
        }
    }
}

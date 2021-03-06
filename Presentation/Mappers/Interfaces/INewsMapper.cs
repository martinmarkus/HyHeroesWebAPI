using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs.NewsDTOs;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.Mappers.Interfaces
{
    public interface INewsMapper
    {
        IList<NewsDTO> MapToNewsDTO(IList<News> newsList);

        NewsDTO MapToNewsDTO(News news);
    }
}

using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.Mapper
{
    public interface INewsMapper
    {
        IList<NewsDTO> MapToNewsDTO(IList<News> newsList);
    }
}

using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs;

namespace HyHeroesWebAPI.Presentation.Mapper
{
    public interface INewsMapper
    {
        NewsDTO MapToNewsDTO(News news);
    }
}

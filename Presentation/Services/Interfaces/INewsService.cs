using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs.NewsDTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface INewsService
    {
        Task<IList<NewsDTO>> GetNewsAsync(int amount);

        Task AddLatestNewsAsnyc(LatestNewsDTO newNewsDTO, User publisherName);

        Task<NewsDTO> GetNewsByIdAsync(Guid id);
    }
}

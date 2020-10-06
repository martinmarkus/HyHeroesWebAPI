using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface INewsService
    {
        Task<NewsDTO> GetNewsAsync();
        Task AddLatestNewsAsnyc(LatestNewsDTO newNewsDTO, User publisherName);
    }
}

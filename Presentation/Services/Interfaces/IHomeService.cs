using HyHeroesWebAPI.Presentation.DTOs.WebsiteDTOs;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IHomeService
    {
        Task<HomeDTO> GetHomeContentAsync(string userName);
    }
}

using HyHeroesWebAPI.Presentation.DTOs;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IAdminService
    {
        Task<GameServerListDTO> GetAllGameServersAsync();
    }
}

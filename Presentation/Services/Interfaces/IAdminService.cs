using HyHeroesWebAPI.Presentation.DTOs;
using System;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IAdminService
    {
        Task<GameServerListDTO> GetAllGameServersAsync();

        Task UpdateGameServerAsync(GameServerDTO gameServerDTO);

        Task DeleteGameServerAsync(Guid serverId);
        
        Task AddGameServerAsync(string serverName);
    }
}

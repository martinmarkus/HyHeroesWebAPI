using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs.ServerIntegrationDTOs;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.Mappers.Interfaces
{
    public interface IGameServerMapper
    {
        GameServerDTO MapToGameServerDTO(GameServer gameServer);
       
        GameServerListDTO MapToGameServerListDTO(IList<GameServer> gameServers);
        
        GameServer MapToGameServer(GameServerDTO gameServerDTO);
    }
}

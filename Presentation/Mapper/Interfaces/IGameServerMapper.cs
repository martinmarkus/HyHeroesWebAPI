using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.Mapper.Interfaces
{
    public interface IGameServerMapper
    {
        GameServerDTO MapToGameServerDTO(GameServer gameServer);
        GameServerListDTO MapToGameServerListDTO(IList<GameServer> gameServers);
    }
}

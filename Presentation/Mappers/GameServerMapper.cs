using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs.ServerIntegrationDTOs;
using HyHeroesWebAPI.Presentation.Mappers.Interfaces;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.Mappers
{
    public class GameServerMapper : IGameServerMapper
    {
        public GameServerListDTO MapToGameServerListDTO(IList<GameServer> gameServers)
        {
            var gameServerListDTO = new GameServerListDTO();

            foreach (var gameServer in gameServers)
            {
                gameServerListDTO.GameServers.Add(MapToGameServerDTO(gameServer));
            }

            return gameServerListDTO;
        }

        public GameServerDTO MapToGameServerDTO(GameServer gameServer) =>
            new GameServerDTO()
            {
                ServerName = gameServer.ServerName,
                IsServerRunning = gameServer.IsServerRunning,
                Id = gameServer.Id
            };

        public GameServer MapToGameServer(GameServerDTO gameServerDTO) =>
            new GameServer()
            {
                ServerName = gameServerDTO.ServerName,
                IsServerRunning = gameServerDTO.IsServerRunning
            };
    }
}

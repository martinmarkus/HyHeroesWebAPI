using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Presentation.DTOs.ServerIntegrationDTOs;
using HyHeroesWebAPI.Presentation.Mappers.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class AdminService : IAdminService
    {
        private readonly IGameServerRepository _gameServerRepository;
        private readonly IGameServerMapper _gameServerMapper;

        public AdminService(
            IGameServerRepository gameServerRepository,
            IGameServerMapper gameServerMapper)
        {
            _gameServerRepository = gameServerRepository ?? throw new ArgumentException(nameof(gameServerRepository));
            _gameServerMapper = gameServerMapper ?? throw new ArgumentException(nameof(gameServerMapper));
        }

        public async Task<GameServerListDTO> GetAllGameServersAsync() =>
            _gameServerMapper.MapToGameServerListDTO(
                await _gameServerRepository.GetAllAsync());

        public async Task UpdateGameServerAsync(GameServerDTO gameServerDTO)
        {
            var gameServer = await _gameServerRepository.GetByIdAsync(gameServerDTO.Id);
            gameServer.IsServerRunning = gameServerDTO.IsServerRunning;

            await _gameServerRepository.UpdateAsync(gameServer);
        }

        public async Task DeleteGameServerAsync(Guid serverId) =>
            await _gameServerRepository.RemoveAsync(serverId);

        public async Task AddGameServerAsync(string serverName) =>
            await _gameServerRepository.AddAsync(new GameServer()
            {
                IsServerRunning = false,
                ServerName = serverName
            });
    }
}

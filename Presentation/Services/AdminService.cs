using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mapper.Interfaces;
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
    }
}

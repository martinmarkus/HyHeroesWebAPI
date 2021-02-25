using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class OnlinePlayerStateGeneratorService : IOnlinePlayerStateGeneratorService
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;

        public OnlinePlayerStateGeneratorService(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory ?? throw new ArgumentException(nameof(serviceScopeFactory));

            GenerateMockPlayerStateDataAsync().ConfigureAwait(true);
        }

        public async Task GenerateMockPlayerStateDataAsync()
        {
            using var scope = _serviceScopeFactory.CreateScope();

            var gameServerRepository = scope.ServiceProvider.GetService<IGameServerRepository>();
            var onlinePlayerStateRepository = scope.ServiceProvider.GetService<IOnlinePlayerStateRepository>();

            await InitWithStartingDataAsync(gameServerRepository, onlinePlayerStateRepository);

            while (true)
            {
                var serverIds = await gameServerRepository.GetAllRunningServerIdsAsync();
                foreach (var serverId in serverIds)
                {
                    await onlinePlayerStateRepository.AddAsync(new OnlinePlayerState()
                    {
                        CreationDate = DateTime.Parse(DateTime.Now.ToString("yyyy/MM/dd HH") + ":00"),
                        GameServerId = serverId,
                        OnlinePlayerCount = new Random().Next(20, 100)
                    });
                }

                Thread.Sleep(600 * 1000);
            }
        }

        private async Task InitWithStartingDataAsync(
            IGameServerRepository gameServerRepository,
            IOnlinePlayerStateRepository onlinePlayerStateRepository)
        {
            await onlinePlayerStateRepository.ClearAsync();

            for (int i = 1; i <= 10; i++)
            {
                var serverIds = await gameServerRepository.GetAllRunningServerIdsAsync();
                foreach (var serverId in serverIds)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        await onlinePlayerStateRepository.AddAsync(new OnlinePlayerState()
                        {
                            CreationDate = DateTime.Parse(DateTime.Now.ToString("yyyy/MM/dd HH") + ":00").AddHours(-1 * i),
                            GameServerId = serverId,
                            OnlinePlayerCount = new Random().Next(20, 100)
                        });
                    }
                }
            }
        }
    }
}

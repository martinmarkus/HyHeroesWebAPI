using Discord.Commands;
using HyHeroesWebAPI.Infrastructure.Infrastructure.ConfigObjects;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Utils
{
    public class DiscordCommands : ModuleBase<SocketCommandContext>
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;
        private readonly bool _useDiscord;

        public DiscordCommands(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;

            using var scope = _serviceScopeFactory.CreateScope();
            _useDiscord = ((IOptions<AppSettings>)scope.ServiceProvider.GetService(typeof(IOptions<AppSettings>)))
                .Value.DiscordSettings.UseDiscordIntegration;
        }

        [Command("bot")]
        public async Task VersionAsync()
        {
            if (_useDiscord)
            {
                await ReplyAsync("*HyHeroes Discord bot v1.0* - by birdemic");
            }
        }
    }
}

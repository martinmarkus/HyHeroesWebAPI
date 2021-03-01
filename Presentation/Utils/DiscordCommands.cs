using Discord.Commands;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Utils
{
    public class DiscordCommands : ModuleBase<SocketCommandContext>
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;

        public DiscordCommands(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;
        }

        [Command("bot")]
        public async Task VersionAsync()
        {
            await ReplyAsync("HyHeroes Discord bot v1.0 - developed by birdemic");
        }
    }
}

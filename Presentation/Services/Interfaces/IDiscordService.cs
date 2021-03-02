using HyHeroesWebAPI.Presentation.DTOs;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IDiscordService
    {
        Task RunBotAsync();

        Task SendMessageToChannelAsync(ulong channelId, string msg);

        Task SendMessageToNewsAsync(string msg);

        Task SendMessageToStaffAsync(string msg);
    }
}

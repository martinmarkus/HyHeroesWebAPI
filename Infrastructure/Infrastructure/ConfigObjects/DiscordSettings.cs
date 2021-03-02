using System.Collections.Generic;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.ConfigObjects
{
    public class DiscordSettings
    {
        public bool UseDiscordIntegration { get; set; }

        public string CommandPrefix { get; set; }

        public  string BotTokenBase64 { get; set; }

        public ulong PublicNewsChannelId { get; set; }

        public ulong PrivateStaffChannelId { get; set; }

        public string PurchaseMessage { get; set; }

        public List<CustomDiscordCommand> CustomCommands { get; set; }
    }
}

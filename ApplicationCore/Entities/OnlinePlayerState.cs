using System;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class OnlinePlayerState : BaseEntity
    {
        public int OnlinePlayerCount { get; set; }

        public Guid GameServerId { get; set; }

        public virtual GameServer GameServer { get; set; }
    }
}

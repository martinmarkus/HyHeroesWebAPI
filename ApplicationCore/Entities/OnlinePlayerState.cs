using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    [Table("onlineplayerstates")]
    public class OnlinePlayerState : BaseEntity
    {
        public int OnlinePlayerCount { get; set; }

        public Guid GameServerId { get; set; }

        public virtual GameServer GameServer { get; set; }
    }
}

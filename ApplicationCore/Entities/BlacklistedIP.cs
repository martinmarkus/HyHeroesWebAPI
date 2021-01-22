using System;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class BlacklistedIP : BaseEntity
    {
        public string IP { get; set; }

        public bool IsIPBanned { get; set; } = true;

        public DateTime BanDate { get; set; } = DateTime.Now;
    }
}

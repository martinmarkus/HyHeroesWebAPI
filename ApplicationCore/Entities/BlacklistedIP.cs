using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    [Table("blacklistedips")]
    public class BlacklistedIP : BaseEntity
    {
        public string IP { get; set; }

        public bool IsIPBanned { get; set; } = true;

        public DateTime BanDate { get; set; } = DateTime.Now;
    }
}

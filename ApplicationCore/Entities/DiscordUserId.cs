using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    [Table("discorduserids")]
    public class DiscordUserId : BaseEntity
    {
        [Required]
        public string DiscordId { get; set; }

        [Required]
        public Guid UserId { get; set; }

        public virtual User User { get; set; }
    }
}

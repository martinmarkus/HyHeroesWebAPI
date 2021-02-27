using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    [Table("notifications")]
    public class Notification : BaseEntity
    {
        [Required]
        public string Message { get; set; }

        [Required]
        public bool IsOpened { get; set; } = false;

        [Required]
        public Guid UserId { get; set; }

        public virtual User User { get; set; }
    }
}

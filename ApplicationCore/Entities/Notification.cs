using System;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
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

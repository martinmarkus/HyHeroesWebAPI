using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    [Table("passwordresetcodes")]
    public class PasswordResetCode : BaseEntity
    {
        public Guid Code { get; set; }

        public bool IsUsed { get; set; } = false;

        public Guid UserId { get; set; }

        public virtual User User { get; set; }
    }
}

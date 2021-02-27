using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    [Table("emailverificationcodes")]
    public class EmailVerificationCode : BaseEntity
    {
        public Guid ActivationCode { get; set; }

        public bool IsActivated { get; set; } = false;

        public string EmailToVerify { get; set; }

        public DateTime ActivationTimeStamp { get; set; }

        public Guid UserId { get; set; }

        public virtual User User { get; set; }
    }
}

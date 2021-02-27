using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    [Table("masskredituseractivations")]
    public class MassKreditUserActivation : BaseEntity
    {
        public Guid UserId { get; set; }

        public Guid MassKreditActivationCodeId { get; set; }

        public DateTime ActivationDate { get; set; }

        public virtual User User { get; set; }

        public virtual MassKreditActivationCode MassKreditActivationCode { get; set; }
    }
}

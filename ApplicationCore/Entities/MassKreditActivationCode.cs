using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    [Table("masskreditactivationcodes")]
    public class MassKreditActivationCode : RandomCodeContainer
    {
        public DateTime StartDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        public int KreditValue { get; set; }

        public virtual ICollection<MassKreditUserActivation> MassKreditUserActivations { get; set; }
    }
}

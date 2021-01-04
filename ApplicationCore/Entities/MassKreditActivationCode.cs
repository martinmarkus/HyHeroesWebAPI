using System;
using System.Collections.Generic;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class MassKreditActivationCode : RandomCodeContainer
    {
        public DateTime StartDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        public int KreditValue { get; set; }

        public virtual ICollection<MassKreditUserActivation> MassKreditUserActivations { get; set; }
    }
}

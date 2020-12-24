using System;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class MassKreditActivationCode : RandomCodeContainer
    {
        public DateTime StartDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        public int KreditValue { get; set; }
    }
}

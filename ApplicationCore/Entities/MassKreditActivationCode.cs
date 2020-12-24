using System;
using System.Collections.Generic;
using System.Text;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class MassKreditActivationCode : BaseEntity
    {
        public string Code { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        public int KreditValue { get; set; }
    }
}

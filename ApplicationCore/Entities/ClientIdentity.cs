using System;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class ClientIdentity : BaseEntity
    {
        public string BaseValue { get; set; }

        public string ValidatorHash { get; set; }

        public string ValidatorSalt { get; set; }

        public DateTime ExpirationDate { get; set; }

        public Guid UserId { get; set; }

        public virtual User User { get; set; }
    }
}

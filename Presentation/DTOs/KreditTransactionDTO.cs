using System;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class KreditTransactionDTO
    {
        public Guid UserId { get; set; }

        public string SecretAdminKey { get; set; }

        public decimal KreditValue { get; set; }
    }
}

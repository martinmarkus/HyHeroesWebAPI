using System;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class KreditTransactionDTO
    {
        public Guid UserId { get; set; }

        public string KreditUploadKey { get; set; }

        public decimal KreditValue { get; set; }
    }
}

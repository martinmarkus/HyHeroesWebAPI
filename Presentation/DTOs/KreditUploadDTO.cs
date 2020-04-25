using System;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class KreditUploadDTO
    {
        public Guid UserId { get; set; }
        public decimal KreditValue { get; set; }
    }
}

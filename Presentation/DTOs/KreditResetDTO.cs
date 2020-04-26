using System;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class KreditResetDTO
    {
        public Guid UserId { get; set; }

        public string KreditUploadKey { get; set; }
    }
}

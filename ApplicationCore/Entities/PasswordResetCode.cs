﻿using System;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class PasswordResetCode : BaseEntity
    {
        public Guid Code { get; set; }

        public bool IsUsed { get; set; } = false;

        public Guid UserId { get; set; }

        public virtual User User { get; set; }
    }
}

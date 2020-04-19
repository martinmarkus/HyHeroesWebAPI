using System;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }

        public bool IsActive { get; set; } = true;
    }
}

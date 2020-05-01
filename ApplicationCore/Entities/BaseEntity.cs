using System;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public bool IsActive { get; set; } = true;
    }
}

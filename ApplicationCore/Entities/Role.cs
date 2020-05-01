using HyHeroesWebAPI.ApplicationCore.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class Role : BaseEntity
    {

        [Required]
        public string Name { get; set; }


        [Required]
        public int PermissionLevel { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}

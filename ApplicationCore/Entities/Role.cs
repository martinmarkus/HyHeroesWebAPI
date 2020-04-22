using HyHeroesWebAPI.ApplicationCore.Enums;
using System.Collections.Generic;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }

        public int PermissionLevel { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    public class Role : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int PermissionLevel { get; set; }
    }
}

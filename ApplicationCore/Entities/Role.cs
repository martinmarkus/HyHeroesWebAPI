using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    [Table("roles")]
    public class Role : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int PermissionLevel { get; set; }
    }
}

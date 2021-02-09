using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class WoodcraftUserListDTO
    {
        [Required]
        [JsonProperty("woodcraftUsers")]
        public IList<WoodcraftUserDTO> WoodcraftUsers { get; set; } = new List<WoodcraftUserDTO>();

        [Required]
        [JsonProperty("woodcraftMigrationKey")]
        public string WoodcraftMigrationKey { get; set; }
    }
}

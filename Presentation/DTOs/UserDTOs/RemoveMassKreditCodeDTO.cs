using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs.UserDTOs
{
    public class RemoveMassKreditCodeDTO
    {
        [Required]
        [JsonProperty("code")]
        public string Code { get; set; }
    }
}

using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs.UserDTOs
{
    public class MassKreditCodeActivationDTO
    {
        [Required]
        [JsonProperty("kreditCode")]
        public string KreditCode { get; set; }
    }
}

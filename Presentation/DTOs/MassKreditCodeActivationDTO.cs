using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class MassKreditCodeActivationDTO
    {
        [Required]
        [JsonProperty("kreditCode")]
        public string KreditCode { get; set; }
    }
}

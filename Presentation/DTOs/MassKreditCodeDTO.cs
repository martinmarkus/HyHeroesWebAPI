using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class MassKreditCodeDTO : NewMassKreditCodeDTO
    {
        [Required]
        [JsonProperty("code")]
        public string Code { get; set; }
    }
}

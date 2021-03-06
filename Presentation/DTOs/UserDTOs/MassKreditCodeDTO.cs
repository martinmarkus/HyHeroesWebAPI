using HyHeroesWebAPI.Presentation.DTOs.NewsDTOs;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs.UserDTOs
{
    public class MassKreditCodeDTO : NewMassKreditCodeDTO
    {
        [Required]
        [JsonProperty("code")]
        public string Code { get; set; }

        [Required]
        [JsonProperty("activationAmount")]
        public int ActivationAmount { get; set; }
    }
}

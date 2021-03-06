using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs.ServerIntegrationDTOs
{
    public class ValidateAuthenticationByExternalListDTO
    {
        [Required]
        [JsonProperty("authUsers")]
        public IList<ValidateAuthenticationByExternalDTO> AuthUsers { get; set; } = new List<ValidateAuthenticationByExternalDTO>();
    }
}

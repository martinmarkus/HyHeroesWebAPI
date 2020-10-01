using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class ApplyKreditDTO
    {
        [Required]
        [JsonProperty("userName")]
        public string UserName { get; set; }

        [Required]
        [JsonProperty("activationCode")]
        public string ActivationCode { get; set; }
    }
}

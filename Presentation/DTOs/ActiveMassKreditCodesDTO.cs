using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class ActiveMassKreditCodesDTO
    {
        [Required]
        [JsonProperty("activeMassKreditCodes")]
        public IList<MassKreditCodeDTO> ActiveMassKreditCodes { get; set; } = new List<MassKreditCodeDTO>();
    }
}

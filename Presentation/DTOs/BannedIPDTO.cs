using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class BannedIPDTO
    {
        [Required]
        [JsonProperty("IP")]
        public string IP { get; set; }

        [Required]
        [JsonProperty("banDate")]
        public DateTime BanDate { get; set; }
    }
}

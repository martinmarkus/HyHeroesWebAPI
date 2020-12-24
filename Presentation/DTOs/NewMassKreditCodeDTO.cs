using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class NewMassKreditCodeDTO
    {
        [Required]
        [JsonProperty("kreditValue")]
        public int KreditValue { get; set; }

        [Required]
        [JsonProperty("startDate")]
        public DateTime StartDate { get; set; }

        [Required]
        [JsonProperty("expirationDate")]
        public DateTime ExpirationDate { get; set; }
    }
}

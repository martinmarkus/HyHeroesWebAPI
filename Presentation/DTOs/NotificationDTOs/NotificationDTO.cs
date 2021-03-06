using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs.NotificationDTOs
{
    public class NotificationDTO
    {
        [Required]
        [JsonProperty("message")]
        public string Message { get; set; }

        [Required]
        [JsonProperty("userName")]
        public string UserName { get; set; }

        [Required]
        [JsonProperty("isOpened")]
        public bool IsOpened { get; set; }

        [Required]
        [JsonProperty("creationDate")]
        public DateTime CreationDate { get; set; }

        [Required]
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}

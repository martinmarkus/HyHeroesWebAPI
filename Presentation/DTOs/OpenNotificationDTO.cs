using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class OpenNotificationDTO
    {
        [Required]
        [JsonProperty("notificationId")]
        public Guid NotificationId { get; set; }
    }
}

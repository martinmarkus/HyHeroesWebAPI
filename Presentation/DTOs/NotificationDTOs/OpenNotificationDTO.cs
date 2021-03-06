using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs.NotificationDTOs
{
    public class OpenNotificationDTO
    {
        [Required]
        [JsonProperty("notificationId")]
        public Guid NotificationId { get; set; }
    }
}

using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs.NotificationDTOs
{
    public class NotificationListDTO
    {
        [Required]
        [JsonProperty("notifications")]
        public IList<NotificationDTO> Notifications { get; set; } = new List<NotificationDTO>();
    }
}

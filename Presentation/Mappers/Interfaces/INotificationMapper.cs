using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.Mappers.Interfaces
{
    public interface INotificationMapper
    {
        NotificationDTO MapToNotificationDTO(Notification notification);
        NotificationListDTO MapToNotificationListDTO(IList<Notification> notifications);
    }
}

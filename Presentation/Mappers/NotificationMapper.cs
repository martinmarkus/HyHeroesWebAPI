using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mappers.Interfaces;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.Mappers
{
    public class NotificationMapper : INotificationMapper
    {
        public NotificationListDTO MapToNotificationListDTO(IList<Notification> notifications)
        {
            var dto = new NotificationListDTO();

            foreach (var notification in notifications)
            {
                dto.Notifications.Add(MapToNotificationDTO(notification));
            }

            return dto;
        }

        public NotificationDTO MapToNotificationDTO(Notification notification) =>
            new NotificationDTO()
            {
                CreationDate = notification.CreationDate,
                IsOpened = notification.IsOpened,
                UserName = notification.User.UserName,
                Message = notification.Message,
                Id = notification.Id.ToString()
            };
    }
}

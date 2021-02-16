using HyHeroesWebAPI.Presentation.DTOs;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface INotificationService
    {
        Task<NotificationListDTO> GetUserNotificationsAsync(string userName);

        Task OpenNotificationAsync(OpenNotificationDTO openNotificationDTO);

        Task<NotificationDTO> CreateKreditGiftNotificationAsync(string senderName, string receiverName, int kreditAmount);
    }
}

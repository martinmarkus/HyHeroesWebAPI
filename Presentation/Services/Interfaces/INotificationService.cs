using HyHeroesWebAPI.ApplicationCore.DataObjects;
using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs;
using System;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface INotificationService
    {
        Task<NotificationListDTO> GetUserNotificationsAsync(string userName);

        Task OpenNotificationAsync(OpenNotificationDTO openNotificationDTO);

        Task<NotificationDTO> CreateKreditGiftNotificationAsync(string senderName, string receiverName, int kreditAmount);
        
        Task CreateInvoiceNotificationAsync(Guid id, string email);
        
        Task CreateKreditPurchaseNotificationAsync(KreditPurchaseNotification kreditPurchaseNotification);
    }
}

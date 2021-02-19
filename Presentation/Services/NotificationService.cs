using HyHeroesWebAPI.ApplicationCore.DataObjects;
using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Presentation.ConfigObjects;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mappers.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class NotificationService : INotificationService
    {
        private readonly IUserRepository _userRepository;
        private readonly INotificationRepository _notificationRepository;

        private readonly INotificationMapper _notificationMapper;

        private readonly IOptions<AppSettings> _options;

        public NotificationService(
            IUserRepository userRepository,
            INotificationRepository notificationRepository,
            INotificationMapper notificationMapper,
            IOptions<AppSettings> options)
        {
            _userRepository = userRepository ?? throw new ArgumentException(nameof(userRepository));
            _notificationRepository = notificationRepository ?? throw new ArgumentException(nameof(notificationRepository));
            _notificationMapper = notificationMapper ?? throw new ArgumentException(nameof(notificationMapper));
            _options = options ?? throw new ArgumentException(nameof(notificationMapper));
        }

        public async Task CreateKreditPurchaseNotificationAsync(KreditPurchaseNotification dto)
        {
            var message = string.Format(
                         _options.Value.NotificationMessages.KreditPurchaseMessage,
                         dto.KreditValue,
                         dto.PaymentType);

            await CreateNotificationAsync(message, dto.UserId);
        }

        public async Task CreateInvoiceNotificationAsync(Guid userId, string email)
        {
            var message = string.Format(
                _options.Value.NotificationMessages.InvoiceNotificationMessage,
                email);
            
            await CreateNotificationAsync(message, userId);
        }

        public async Task<NotificationListDTO> GetUserNotificationsAsync(string userName)
        {
            var user = await _userRepository.GetByUserNameAsync(userName);
            if (user == null)
            {
                throw new NotFoundException();
            }

            var notOpenedNotifications = await _notificationRepository.GetNotOpenedsByUserIdAsync(user.Id);
            var lastOpenedNotifications = await _notificationRepository.GetLastOpenedsByUserIdAsync(user.Id);

            (notOpenedNotifications as List<Notification>)?.AddRange(lastOpenedNotifications);

            return _notificationMapper.MapToNotificationListDTO(notOpenedNotifications);
        }

        public async Task OpenNotificationAsync(OpenNotificationDTO openNotificationDTO)
        {
            var notification = await _notificationRepository.GetByIdAsync(openNotificationDTO.NotificationId);
            if (notification == null)
            {
                throw new NotFoundException();
            }

            if (!notification.IsOpened)
            {
                notification.IsOpened = true;
                await _notificationRepository.UpdateAsync(notification);
            }
        }

        public async Task<NotificationDTO> CreateKreditGiftNotificationAsync(
            string senderName,
            string receiverName,
            int kreditAmount)
        {
            var sender = await _userRepository.GetByUserNameAsync(senderName);
            if (sender == null)
            {
                throw new NotFoundException();
            }

            var receiver = await _userRepository.GetByUserNameAsync(receiverName);
            if (receiver == null)
            {
                throw new NotFoundException();
            }

            var message = string.Format(
                _options.Value.NotificationMessages.KreditGiftMessage,
                sender.UserName,
                kreditAmount);

            return await CreateNotificationAsync(message, receiver.Id);
        }

        private async Task<NotificationDTO> CreateNotificationAsync(string message, Guid userId) =>
            _notificationMapper.MapToNotificationDTO(await _notificationRepository.AddAsync(new Notification()
            {
                Message = message,
                UserId = userId
            }));
    }
}

﻿using HyHeroesWebAPI.Infrastructure.Infrastructure.ConfigObjects;
using HyHeroesWebAPI.Presentation.DTOs.UserDTOs;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IEmailSenderService
    {
        Task<bool> SendEmailAsync(
            EmailReceiverDTO emailReceiverDTO,
            BaseMailOptions mailOptions,
            SmtpHost smtpHost);

        Task<bool> SendEmailAsync(
            EmailReceiverDTO emailReceiverDTO,
            BaseMailOptions mailOptions,
            string customBody,
            SmtpHost smtpHost);
    }
}

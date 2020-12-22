using HyHeroesWebAPI.Presentation.ConfigObjects;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Options;
using MimeKit;
using System;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class EmailSenderService : IEmailSenderService
    {
        public async Task<bool> SendEmailAsync(
            EmailReceiverDTO emailReceiverDTO,
            BaseMailOptions mailOptions,
            SmtpHost smtpHost)
        {

            if (emailReceiverDTO == null)
            {
                return false;
            }

            var mailMessage = new MimeMessage();

            mailMessage.From.Add(new MailboxAddress(
                mailOptions.SenderName,
                mailOptions.SenderEmail));

            mailMessage.To.Add(new MailboxAddress(
                emailReceiverDTO.ReceiverName,
                emailReceiverDTO.ReceiverEmail));

            mailMessage.Subject = mailOptions.Subject;
            mailMessage.Body = new TextPart("html")
            {
                Text = mailOptions.BodyWithHtml
            };

            using (var smtpClient = new SmtpClient())
            {
                smtpClient.Connect(
                    smtpHost.Host,
                    Int32.Parse(smtpHost.Port),
                    Boolean.Parse(smtpHost.EnableSsl));

                smtpClient.Authenticate(
                    smtpHost.UserName,
                    smtpHost.Password);

                await smtpClient.SendAsync(mailMessage);

                smtpClient.Disconnect(true);
            }

            return true;
        }

        public async Task<bool> SendEmailAsync(
            EmailReceiverDTO emailReceiverDTO,
            BaseMailOptions mailOptions,
            string customBody,
            SmtpHost smtpHost)
        {

            if (emailReceiverDTO == null)
            {
                return false;
            }

            var mailMessage = new MimeMessage();

            mailMessage.From.Add(new MailboxAddress(
                mailOptions.SenderName,
                mailOptions.SenderEmail));

            mailMessage.To.Add(new MailboxAddress(
                emailReceiverDTO.ReceiverName,
                emailReceiverDTO.ReceiverEmail));

            mailMessage.Subject = mailOptions.Subject;
            mailMessage.Body = new TextPart("html")
            {
                Text = customBody
            };

            using (var smtpClient = new SmtpClient())
            {
                smtpClient.Connect(
                    smtpHost.Host,
                    Int32.Parse(smtpHost.Port),
                    Boolean.Parse(smtpHost.EnableSsl));

                smtpClient.Authenticate(
                    smtpHost.UserName,
                    smtpHost.Password);

                await smtpClient.SendAsync(mailMessage);

                smtpClient.Disconnect(true);
            }

            return true;
        }
    }
}

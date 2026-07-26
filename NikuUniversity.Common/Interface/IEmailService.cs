using System;
using System.Collections.Generic;
using System.Text;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using System.Net.Mail;

namespace NikuUniversity.Common.Interface
{
    
    public interface IEmailService
    {
        Task SendEmailAsync(string toEmail, string subject, string body, bool isHtml = true);
        Task SendEmailAsync(string toEmail, string subject, string body, List<string>? cc = null, List<string>? bcc = null, bool isHtml = true);
        Task SendEmailWithAttachmentAsync(string toEmail, string subject, string body, string attachmentPath, bool isHtml = true);
    }

    public class EmailService : IEmailService
    {
        private readonly EmailSettings _settings;

        public EmailService(IOptions<EmailSettings> settings)
        {
            _settings = settings.Value;
        }

        public async Task SendEmailAsync(string toEmail, string subject, string body, bool isHtml = true)
        {
            await SendEmailAsync(toEmail, subject, body, null, null, isHtml);
        }

        public async Task SendEmailAsync(
            string toEmail,
            string subject,
            string body,
            List<string>? cc = null,
            List<string>? bcc = null,
            bool isHtml = true)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(_settings.SenderName, _settings.SenderEmail));
            message.To.Add(MailboxAddress.Parse(toEmail));
            message.Subject = subject;

            if (cc != null)
            {
                foreach (var email in cc)
                    message.Cc.Add(MailboxAddress.Parse(email));
            }

            if (bcc != null)
            {
                foreach (var email in bcc)
                    message.Bcc.Add(MailboxAddress.Parse(email));
            }

            var bodyBuilder = new BodyBuilder();
            if (isHtml)
                bodyBuilder.HtmlBody = body;
            else
                bodyBuilder.TextBody = body;

            message.Body = bodyBuilder.ToMessageBody();

            using var client = new SmtpClient();
            try
            {
                await client.ConnectAsync(_settings.SmtpServer, _settings.SmtpPort,
                    _settings.EnableSsl ? SecureSocketOptions.StartTls : SecureSocketOptions.None);

                await client.AuthenticateAsync(_settings.Username, _settings.Password);
                await client.SendAsync(message);
            }
            finally
            {
                await client.DisconnectAsync(true);
            }
        }

        public async Task SendEmailWithAttachmentAsync(
            string toEmail,
            string subject,
            string body,
            string attachmentPath,
            bool isHtml = true)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(_settings.SenderName, _settings.SenderEmail));
            message.To.Add(MailboxAddress.Parse(toEmail));
            message.Subject = subject;

            var bodyBuilder = new BodyBuilder();
            if (isHtml)
                bodyBuilder.HtmlBody = body;
            else
                bodyBuilder.TextBody = body;

            if (File.Exists(attachmentPath))
            {
                bodyBuilder.Attachments.Add(attachmentPath);
            }

            message.Body = bodyBuilder.ToMessageBody();

            using var client = new SmtpClient();
            try
            {
                await client.ConnectAsync(_settings.SmtpServer, _settings.SmtpPort,
                    _settings.EnableSsl ? SecureSocketOptions.StartTls : SecureSocketOptions.None);

                await client.AuthenticateAsync(_settings.Username, _settings.Password);
                await client.SendAsync(message);
            }
            finally
            {
                await client.DisconnectAsync(true);
            }
        }
    }
}

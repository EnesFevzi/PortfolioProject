using MailKit;
using MailKit.Net.Smtp;
using MimeKit;
using PortfolioProject.Service.Models;
using PortfolioProject.Service.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Service.Service.Concrete
{
    public class SendMailService : ISendMailService
    {

        public Task<bool> SendMail(MailRequest mailRequest)
        {

            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("Portfolyo Project İletişim", mailRequest.SenderMail);

            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("SuperAdmin", "enssfevzi@gmail.com");
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = mailRequest.Body;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = mailRequest.Subject;

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("portfolyoproject@gmail.com", "wxziikpdyllopovs");
            client.Send(mimeMessage);
            client.Disconnect(true);
            return Task.FromResult(true);
        }
    }
}

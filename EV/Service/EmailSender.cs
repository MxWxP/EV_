using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Logging;
using MailKit.Security;
using MimeKit.Text;
using MimeKit;
using MailKit.Net.Smtp;

namespace EV.Service
{
    public class EmailSender : IEmailSender
    {
      

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Execute(email, subject, htmlMessage);
        }

        public async Task Execute(string email, string subject, string body) {
            var emaill = new MimeMessage();
            //не до конца понимать зачем второе занчение , но оно работате , трогать только осторожно
            emaill.From.Add(new MailboxAddress("testsenderemaileventpl@gmail.com", "RmgA_mh3RA5XUzV4ARQlxM"));
            emaill.To.Add(new MailboxAddress("", email));
            emaill.Subject = subject;
            //TODO стилизовать письмо
          //  emaill.Body = new TextPart(body);
            emaill.Body = new TextPart(TextFormat.Html) { Text = body };

            // send email using
            var smtp = new SmtpClient();
            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("testsenderemaileventpl@gmail.com", "tsnj zlye fnux jqgu");
            smtp.Send(emaill);
            smtp.Disconnect(true);
            



        }
    }
}

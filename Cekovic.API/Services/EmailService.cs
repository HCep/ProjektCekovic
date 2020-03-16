using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Cekovic.API.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _cofiguration;
        public EmailService(IConfiguration configuration)
        {
            _cofiguration = configuration;
        }
        public async Task SendEmail(string email, string subject, string message)
        {
           using(var client = new SmtpClient())
           {
               var credential = new NetworkCredential
               {
                   UserName = _cofiguration["Email:cekovicweb@gmail.com"],
                   Password = _cofiguration["Email:Wiaranadziejamilosc@!#"]
               };

               client.Credentials = credential;
               client.Host = _cofiguration["Email:smtp.webio.pl"];
               client.Port = int.Parse(_cofiguration["Email:465"]);
               client.EnableSsl = true;

               using(var emailMessage = new MailMessage())
               {
                   emailMessage.To.Add(new MailAddress(email));
                   emailMessage.From = new MailAddress(_cofiguration["Email:cekovicweb@gmail.com"]);
                   emailMessage.Subject = subject;
                   emailMessage.Body = message;
                   client.Send(emailMessage);
               }
           }
           await Task.CompletedTask;
        }
    }
}
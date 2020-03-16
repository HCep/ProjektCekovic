using System.Threading.Tasks;

namespace Cekovic.API.Services
{
    public interface IEmailService
    {
         Task SendEmail(string email,string subject, string message);
    }
}
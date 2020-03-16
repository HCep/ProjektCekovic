using System.Threading.Tasks;
using Cekovic.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cekovic.API.Controllers
{
    [Route("api/send-email")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IEmailService _emailService;
        public AccountController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]
        public async Task<IActionResult> SendEmailAsync([FromBody]string email,string subject, string message)
        {
            await _emailService.SendEmail(email, subject, message);
            return Ok(200);
        }
    }
}
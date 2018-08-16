using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anc10_MVC_NET461_IndAuth.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}

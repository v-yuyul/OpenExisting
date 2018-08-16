using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anc20_MVCWithClassLib_Core_IndAuth.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}

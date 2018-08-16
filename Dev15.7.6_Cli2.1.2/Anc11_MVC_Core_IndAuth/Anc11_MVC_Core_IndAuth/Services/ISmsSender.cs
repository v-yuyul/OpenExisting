using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anc11_MVC_Core_IndAuth.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}

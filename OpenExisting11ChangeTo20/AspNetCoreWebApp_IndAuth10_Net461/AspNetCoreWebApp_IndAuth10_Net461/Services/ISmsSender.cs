using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreWebApp_IndAuth10_Net461.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}

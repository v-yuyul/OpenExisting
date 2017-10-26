using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_NetFramework_Ind10_OnNet461.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}

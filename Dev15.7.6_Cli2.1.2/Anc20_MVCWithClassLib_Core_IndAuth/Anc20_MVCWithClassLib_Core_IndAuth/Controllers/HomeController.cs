using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Anc20_MVCWithClassLib_Core_IndAuth.Models;

namespace Anc20_MVCWithClassLib_Core_IndAuth.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ClassLibrary_Standard.Class1 c = new ClassLibrary_Standard.Class1();

            ViewData["Message"] = "Your application description page." + c.GetHello();

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

// A controller is responsible for controlling the way a user interacts with an MVC application.
// A controller contains control-of-flow logic for an ASP.NET MVC application.
// A controller determines which response to send to a user when a user makes a browser request.

using Microsoft.AspNetCore.Mvc;
using SaleOfSnacks.Models;
using System.Diagnostics;

namespace SaleOfSnacks.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Demo()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
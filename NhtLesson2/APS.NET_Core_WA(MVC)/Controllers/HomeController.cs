using APS.NET_Core_WA_MVC_.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace APS.NET_Core_WA_MVC_.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.name = "ThanhhNg";
            return View();
        }

        public IActionResult Privacy()
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

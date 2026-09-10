using Microsoft.AspNetCore.Mvc;
using NhtLesson4Lab03.Models;
using System.Diagnostics;

namespace NhtLesson4Lab03.Controllers
{
    public class HomeController : Controller
    {
        protected Product product = new Product();
        public IActionResult Index()
        {
            
            ViewBag.Products = product.GetProducts();
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

using Microsoft.AspNetCore.Mvc;

namespace NhtLesson09Lab.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

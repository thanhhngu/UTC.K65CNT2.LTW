using Microsoft.AspNetCore.Mvc;

namespace NhtLesson09Lab.Areas.Admins.Controllers
{
    [Area("Admins")]

    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

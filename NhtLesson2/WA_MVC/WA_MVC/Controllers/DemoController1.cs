using Microsoft.AspNetCore.Mvc;

namespace WA_MVC.Controllers
{
    public class DemoController1 : Controller
    {
        public IActionResult DemoView()
        {
            return View();
        }
    }
}

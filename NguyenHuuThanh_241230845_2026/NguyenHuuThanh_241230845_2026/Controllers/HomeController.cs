using Microsoft.AspNetCore.Mvc;
using NguyenHuuThanh_241230845_2026.Data;
using NguyenHuuThanh_241230845_2026.Models;
using System.Diagnostics;

namespace NguyenHuuThanh_241230845_2026.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var list = _db.Saches.Where(s => s.Gia > 100 && s.Gia != null).ToList();
            return View(list);
        }

        public IActionResult GetBooksByCategory(int Id)
        {
            var list = _db.Saches.Where(s => s.MaTl == Id).ToList();
            return PartialView("NguyenHuuThanh_MainContent", list);
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

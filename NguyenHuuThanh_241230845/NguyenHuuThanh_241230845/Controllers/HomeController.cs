using Microsoft.AspNetCore.Mvc;
using NguyenHuuThanh_241230845.Data;
using NguyenHuuThanh_241230845.Models;
using System.Diagnostics;

namespace NguyenHuuThanh_241230845.Controllers
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
            var lh = _db.HangHoas.Where(h => h.Gia > 100).ToList();
            return View(lh);
        }

        public IActionResult Cate(int MaLoai)
        {
            var lh = _db.HangHoas.Where(h => h.MaLoai == MaLoai).ToList();
            return PartialView("_NguyenHuuThanh_MainContent", lh);
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

using Microsoft.AspNetCore.Mvc;
using NguyenHuuThanh_241230845_QLTS1.Data;
using NguyenHuuThanh_241230845_QLTS1.Models;
using System.Diagnostics;

namespace NguyenHuuThanh_241230845_QLTS1.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult GetPBC(int MaTS)
        {
            var l = _db.TaiSans.Where(ts => ts.NguyenGia > 20 && ts.NguyenGia != null && ts.MaLoai == MaTS).ToList();
            return PartialView("NguyenHuuThanh_MainContent", l);
        }
        public IActionResult Index()
        {
            var l = _db.TaiSans.Where(ts => ts.NguyenGia > 20 && ts.NguyenGia != null);
            return View(l);
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

using Microsoft.AspNetCore.Mvc;
using NguyenHuuThanh_241230845_QLTS2.Data;
using NguyenHuuThanh_241230845_QLTS2.Models;
using System.Diagnostics;

namespace NguyenHuuThanh_241230845_QLTS2.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }

        
        public IActionResult GetPBC(int MaL)
        {
            var l = _db.TaiSans.Where(ts => ts.NguyenGia > 20 && ts.NguyenGia != null && ts.MaLoai == MaL).ToList();
            return PartialView("NguyenHuuThanh_MainContent", l);
        }

        public IActionResult Index()
        {
            var l = _db.TaiSans.Where(ts => ts.NguyenGia > 20 && ts.NguyenGia != null).ToList();
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

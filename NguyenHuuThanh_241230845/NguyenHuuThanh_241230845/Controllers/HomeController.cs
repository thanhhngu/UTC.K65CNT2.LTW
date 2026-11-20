using Microsoft.AspNetCore.Mvc;
using NguyenHuuThanh_241230845.Data;
using NguyenHuuThanh_241230845.Models;
using System.Diagnostics;

namespace NguyenHuuThanh_241230845.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult GetProductsWithinCategory(int Maloai)
        {
            var l = _context.HangHoas.Where(h => h.Maloai == Maloai).ToList();
            return PartialView("NguyenHuuThanh_MainContent", l);
        }
        public IActionResult Index()
        {
            var l = _context.HangHoas.Where(h => h.Gia > 100).ToList();
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

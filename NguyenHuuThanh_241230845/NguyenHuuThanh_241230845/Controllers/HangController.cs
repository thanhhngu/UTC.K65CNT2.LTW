using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NguyenHuuThanh_241230845.Data;
using NguyenHuuThanh_241230845.Models;
using NguyenHuuThanh_241230845.ViewModels;

namespace NguyenHuuThanh_241230845.Controllers
{
    public class HangController : Controller
    {
        private readonly AppDbContext _context;
        public HangController(AppDbContext context)
        {
            _context = context;
        }
        
        public ActionResult Create()
        {
            ViewBag.LoaiHang = new SelectList(_context.LoaiHangs, "MaLoai", "TenLoai");
            return View(new HangViewModel());
        }

        // POST: HangController/Create
        [HttpPost]

        public async Task<ActionResult> Create(HangViewModel h)
        {
            if (ModelState.IsValid)
            {
                var tmp = new HangHoa()
                {
                    Maloai = h.Maloai,
                    TenHang = h.TenHang,
                    Gia = h.Gia,
                    Anh = h.Anh
                };
                _context.HangHoas.Add(tmp);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            ViewBag.LoaiHang = new SelectList(_context.LoaiHangs, "Maloai", "Tenloai");
            return View(h);
        }

       
    }
}

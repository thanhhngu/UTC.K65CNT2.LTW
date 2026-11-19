using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NguyenHuuThanh_241230845.Data;
using NguyenHuuThanh_241230845.ViewModels;

namespace NguyenHuuThanh_241230845.Controllers
{
    public class CreateController : Controller
    {
        private readonly AppDbContext _context;
        public CreateController(AppDbContext context)
        {
            _context = context;
        }

        public ActionResult Create()
        {
            var loaihang = _context.LoaiHangs;
            ViewBag.LoaiHangs = new SelectList(loaihang, "MaLoai", "MaLoai");
            return View(new CreateHang());
        }

        // POST: CreateController/Create
        [HttpPost]
        public async Task<ActionResult> CreateAsync(CreateHang vm)
        {
            if (ModelState.IsValid)
            {
                var hanghoa = new Models.HangHoa
                {
                    MaLoai = vm.MaLoai,
                    TenHang = vm.TenHang,
                    Gia = vm.Gia,
                    Anh = vm.Anh
                };
                _context.Add(hanghoa);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            var loaihang = _context.LoaiHangs;
            ViewBag.LoaiHangs = new SelectList(loaihang, "MaLoai", "MaLoai");
            return View(vm);
        }

       
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NguyenHuuThanh_241230845_2026.Data;
using NguyenHuuThanh_241230845_2026.ViewModels.SachViewModel;

namespace NguyenHuuThanh_241230845_2026.Controllers
{
    public class SachController : Controller
    {
        private readonly AppDbContext _db;
        public SachController(AppDbContext db)
        {
            _db = db;
        }

        public ActionResult Create()
        {
            ViewBag.TheLoais = new SelectList(_db.TheLoais, "MaTl", "TenTl");
            return View(new SachViewModel());
        }

        // POST: SachController/Create
        [HttpPost]
        public ActionResult Create(SachViewModel s)
        {
            if(ModelState.IsValid)
            {
                var sach = new Models.Sach
                {
                    TenSach = s.TenSach,
                    Anh = s.Anh,
                    Gia = s.Gia,
                    MaTl = s.MaTl
                };
                _db.Saches.Add(sach);
                _db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            ViewBag.TheLoais = new SelectList(_db.TheLoais, "MaTl", "TenTl");
            return View(s);
        }

        
    }
}

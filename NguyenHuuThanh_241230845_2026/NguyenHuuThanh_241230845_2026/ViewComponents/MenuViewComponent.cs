using Microsoft.AspNetCore.Mvc;
using NguyenHuuThanh_241230845_2026.Data;

namespace NguyenHuuThanh_241230845_2026.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        private AppDbContext _db;
        public MenuViewComponent(AppDbContext db)
        {
            _db = db;
        }
        public IViewComponentResult Invoke()
        {
            var list = _db.TheLoais.ToList();
            return View(list);
        }
    }
}

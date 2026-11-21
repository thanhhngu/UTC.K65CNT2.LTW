using Microsoft.AspNetCore.Mvc;
using NguyenHuuThanh_241230845_QLTS1.Data;

namespace NguyenHuuThanh_241230845_QLTS1.ViewComponents
{
    public class MenuViewComponent : ViewComponent

    {
        private readonly AppDbContext _db;
        public MenuViewComponent(AppDbContext db)
        {
            _db = db;
        }
        public IViewComponentResult Invoke()
        {
            var menus = _db.LoaiTaiSans.ToList();
            return View(menus);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using NguyenHuuThanh_241230845.Data;

namespace NguyenHuuThanh_241230845.ViewComponents
{
    public class MenuViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;
        public MenuViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var menu = _context.LoaiHangs.ToList();
            return View(menu);
        }
    }
}

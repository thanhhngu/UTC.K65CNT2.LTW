using Microsoft.AspNetCore.Mvc;

namespace NhtLesson10Lab.ViewComponents
{
    public class RenderViewComponent : ViewComponent
    {
        private List<Models.MenuItem> _menuItems = new List<Models.MenuItem>
        {
            new Models.MenuItem { Id = 1, Name = "Home", Link = "/" },
            new Models.MenuItem { Id = 2, Name = "Students", Link = "/Admin/Student/List" },
            new Models.MenuItem { Id = 3, Name = "Add student", Link = "/Admin/Student/Create" },
            new Models.MenuItem { Id = 4, Name = "Privacy", Link = "/Home/Privacy" }
        };

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(_menuItems);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using NhtLesson11Lab04.Data;
using NhtLesson11Lab04.Models;

namespace NhtLesson11Lab04Lab05Lab06.ViewComponents

{
    public class MajorViewComponent : ViewComponent
    {
        SchoolDBContext _context;
        List<Major> _majors;
        public MajorViewComponent(SchoolDBContext context)
        {
            _context = context;
            _majors = _context.Majors.ToList();
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("RenderMajor", _majors);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using NhtLesson4Lab03.Models;

namespace NhtLesson4Lab03.ViewComponents
{
    public class BookViewComponent : ViewComponent
    {
        protected Book book = new Book();
        public IViewComponentResult Invoke()
        {
            var books = book.GetBooks();
            return View(books);
        }
    }
}

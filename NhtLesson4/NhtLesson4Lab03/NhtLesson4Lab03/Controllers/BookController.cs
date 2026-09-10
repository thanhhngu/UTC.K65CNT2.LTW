using Microsoft.AspNetCore.Mvc;
using NhtLesson4Lab03.Models;

namespace NhtLesson4Lab03.Controllers
{
    public class BookController : Controller
    {
        protected Book book = new Book();
        public IActionResult Index()
        {
            ViewBag.authors = book.Authers;
            ViewBag.genres = book.Genres;
            var books = book.GetBooks();
            return View(books);

        }

        public IActionResult Create()
        {
            ViewBag.authors = book.Authers;
            ViewBag.genres = book.Genres;
            Book model = new Book();
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            ViewBag.authors = book.Authers;
            ViewBag.genres = book.Genres;
            var model = book.GetBookById(id);
            return View(model);
        }

        public PartialViewResult _BookList()
        {
            var books = book.GetBooks();
            return PartialView(books);
        }

    }
}

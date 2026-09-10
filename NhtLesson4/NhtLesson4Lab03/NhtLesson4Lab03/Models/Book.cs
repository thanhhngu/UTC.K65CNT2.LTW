using Microsoft.AspNetCore.Mvc.Rendering;

namespace NhtLesson4Lab03.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public int TotalPage { get; set; }
        public string Summary { get; set; }

        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book { Id = 1, Title = "Book 1", AuthorId = 1, GenreId = 1, Image = "/images/book1.jpg", Price = 9.99f, TotalPage = 200, Summary = "Summary of Book 1" },
                new Book { Id = 2, Title = "Book 2", AuthorId = 2, GenreId = 2, Image = "/images/book2.jpg", Price = 14.99f, TotalPage = 300, Summary = "Summary of Book 2" },
                new Book { Id = 3, Title = "Book 3", AuthorId = 3, GenreId = 3, Image = "/images/book3.jpg", Price = 19.99f, TotalPage = 400, Summary = "Summary of Book 3" }
            };
        }

        public Book GetBookById(int id)
        {
            return GetBooks().FirstOrDefault(b => b.Id == id);
        }

        public List<SelectListItem> Authers { get; } = new List<SelectListItem>()
        {
            new SelectListItem { Value = "1", Text = "Author 1" },
            new SelectListItem { Value = "2", Text = "Author 2" },
            new SelectListItem { Value = "3", Text = "Author 3" }
        };


        public List<SelectListItem> Genres { get; } = new List<SelectListItem>()
        {
            new SelectListItem { Value = "1", Text = "Genre 1" },
            new SelectListItem { Value = "2", Text = "Genre 2" },
            new SelectListItem { Value = "3", Text = "Genre 3" }
        };
    }
}

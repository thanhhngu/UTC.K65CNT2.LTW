using Microsoft.AspNetCore.Mvc.Rendering;

namespace NhtLesson4Lab03.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Category { get; set; }

    
        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Image = "/images/book1.jpg", Category = "Category 1" },
                new Product { Id = 2, Name = "Product 2", Image = "/images/book2.jpg", Category = "Category 2" },
                new Product { Id = 3, Name = "Product 3", Image = "/images/book3.jpg", Category = "Category 3" },
            };
        }

    }
}

namespace NhtLesson3Lab02.Models
{
    public class Category
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}

using Microsoft.AspNetCore.Mvc;
using NhtLesson3Lab02.Models;

namespace NhtLesson3Lab02.Controllers
{
    public class ProductController : Controller
    {
        List<Category> categories = new List<Category>() {
                new Category()
                {
                    Name = "Quần Áo",
                    Products = new List<Product>()
                    {
                        new Product { Id = 1, Name = "Bộ đồ bơi cho trẻ em nam", Img = "bodo1.jpg", Description = "Chất liệu thun lạnh cao cấp, co giãn tốt.", Price = 35000, Qty = 20 },
                        new Product { Id = 2, Name = "Bộ đồ bơi cho trẻ em nữ", Img = "bodo2.jpg", Description = "Thiết kế dễ thương, an toàn cho da bé.", Price = 35000, Qty = 15 }
                    }
                },
                new Category()
                {
                    Name = "Túi xách",
                    Products = new List<Product>()
                    {
                        new Product { Id = 3, Name = "Túi thời trang mẫu mới 2021", Img = "tui1.jpg", Description = "Kiểu dáng thanh lịch, phù hợp đi làm và đi chơi.", Price = 450000, Qty = 10 },
                        new Product { Id = 4, Name = "Túi thời trang da cá sấu", Img = "tui2.jpg", Description = "Chất liệu da tổng hợp vân cá sấu sang trọng.", Price = 550000, Qty = 5 }
                    }
                },
                new Category()
                {
                    Name = "Đồng hồ",
                    Products = new List<Product>()
                    {
                        new Product { Id = 5, Name = "Đồng hồ thông minh trẻ em", Img = "dongho1.jpg", Description = "Hỗ trợ định vị GPS, gọi điện 2 chiều.", Price = 250000, Qty = 30 },
                        new Product { Id = 6, Name = "Đồng hồ thể thao nam", Img = "dongho2.jpg", Description = "Chống nước 5ATM, pin sử dụng 14 ngày.", Price = 890000, Qty = 12 }
                    }
                }
            };
        public IActionResult Index()
        {   
            ViewBag.AllCategories = categories;
            return View(categories);
        }

        [Route("Product/Details/{id}", Name = "ProductDetails")]
        public IActionResult Details(int id)
        {
            Product sp;
            foreach (var item in categories)
            {
                sp = item.Products.FirstOrDefault(p => p.Id == id);
                if (sp != null)
                {
                    return View(sp);
                }
            }
            return NotFound();
        }

        [Route("Product/ShowByCategory/{categoryName}", Name = "ShowByCategory")]
        public IActionResult ShowByCategory(string categoryName)
        {
            var category = categories.FirstOrDefault(c => c.Name == categoryName);
            if (category == null)
            {
                return NotFound();
            }
            List<Category> categoryList = new List<Category>();
            categoryList.Add(category);
            ViewBag.AllCategories = categories;
            return View("Index" ,categoryList);
        }
    }
}

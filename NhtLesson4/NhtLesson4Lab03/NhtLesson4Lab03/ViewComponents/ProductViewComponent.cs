using Microsoft.AspNetCore.Mvc;
using NhtLesson4Lab03.Models;
namespace NhtLesson4Lab03.ViewComponents
{
    public class ProductViewComponent : ViewComponent
    {
        protected Product product = new Product();
        public IViewComponentResult Invoke()
        {
            var products = product.GetProducts();
            return View(products);
        }
    }
}

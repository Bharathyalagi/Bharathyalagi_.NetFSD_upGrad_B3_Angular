using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>()
            {
                new Product{ ProductId=1, ProductName="Laptop", Category="Electronics", Price=50000},
                new Product{ ProductId=2, ProductName="Mobile", Category="Electronics", Price=23000},
                new Product{ ProductId=3, ProductName="Shoes", Category="Fashion", Price=3000},
            };
            return View(products);
        }
        public IActionResult Details(int id)
        {
            var products = new List<Product>()
            {
                new Product{ ProductId=1, ProductName="Laptop", Category="Electronics", Price=50000 },
                new Product{ ProductId=2, ProductName="Phone", Category="Electronics", Price=20000 },
                new Product{ ProductId=3, ProductName="Shoes", Category="Fashion", Price=3000 }
            };

            var product = products.FirstOrDefault(p => p.ProductId == id);

            return View(product);

        }
    }
}

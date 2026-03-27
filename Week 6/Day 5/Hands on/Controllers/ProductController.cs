using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class ProductController : Controller
    {
        public static List<Product> products = new List<Product>()
        {
            new Product { ProductId = 1, ProductName = "Laptop", Category = "Electronics", Price = 50000 },
            new Product { ProductId = 2, ProductName = "Mobile", Category = "Electronics", Price = 20000 }
        };

        public IActionResult Index()
        {
            return View(products);
        }

        public IActionResult Details(int id)
        {
            var product = products.FirstOrDefault(p => p.ProductId == id);
            return View(product);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product obj)
        {
            if (ModelState.IsValid)
            {
                products.Add(obj);
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = products.FirstOrDefault(p => p.ProductId == id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product obj)
        {
            var existing = products.FirstOrDefault(p => p.ProductId == obj.ProductId);

            existing.ProductName = obj.ProductName;
            existing.Category = obj.Category;
            existing.Price = obj.Price;

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var product = products.FirstOrDefault(p => p.ProductId == id);
            return View(product);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            var product = products.FirstOrDefault(p => p.ProductId == id);
            products.Remove(product);
            return RedirectToAction("Index");
        }
    }
}
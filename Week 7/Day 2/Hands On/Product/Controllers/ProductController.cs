using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        public static List<dynamic> products = new List<dynamic>();

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.Products = products;
            return View();
        }

        [HttpPost("")]
        public IActionResult Index(string name, double price, int qty)
        {
            products.Add(new { Name = name, Price = price, Qty = qty });
            ViewBag.Products = products;
            return View();
        }
    }
}
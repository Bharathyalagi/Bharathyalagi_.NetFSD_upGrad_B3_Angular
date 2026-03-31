using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var list = _context.Products.ToList();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product p)
        {
            _context.Products.Add(p);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
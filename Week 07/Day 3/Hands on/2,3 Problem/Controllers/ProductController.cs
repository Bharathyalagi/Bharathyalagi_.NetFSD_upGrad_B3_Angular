using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        public IActionResult ShowContacts()
        {
            return View(_service.GetAllContacts());
        }

        public IActionResult GetContactById(int id)
        {
            var contact = _service.GetContactById(id);
            return View(contact);
        }

        public IActionResult AddContact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddContact(Product contact)
        {
            _service.AddContact(contact);
            return RedirectToAction("ShowContacts");
        }
    }
}
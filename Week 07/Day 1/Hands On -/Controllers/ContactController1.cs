using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class ContactController : Controller
    {
        public static List<ContactInfo> contacts = new List<ContactInfo>();

        public IActionResult Index()
        {
            return View(contacts);
        }

        public IActionResult GetContactById(int id)
        {
            var contact = contacts.FirstOrDefault(x => x.ContactId == id);
            return View(contact);
        }

        public IActionResult AddContact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddContact(ContactInfo contactInfo)
        {
            contacts.Add(contactInfo);
            return RedirectToAction("Index");
        }
    }
}
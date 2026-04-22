using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

public class ContactController : Controller
{
    private readonly IContactRepository _repo;

    public ContactController(IContactRepository repo)
    {
        _repo = repo;
    }

    public IActionResult ShowContacts()
    {
        var data = _repo.GetAllContacts();
        return View(data);
    }

    public IActionResult AddContact()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddContact(ContactInfo contact)
    {
        _repo.AddContact(contact);
        return RedirectToAction("ShowContacts");
    }

    public IActionResult DeleteContact(int id)
    {
        _repo.DeleteContact(id);
        return RedirectToAction("ShowContacts");
    }
}
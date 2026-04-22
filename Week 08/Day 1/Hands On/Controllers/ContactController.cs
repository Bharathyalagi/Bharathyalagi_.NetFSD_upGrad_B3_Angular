using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories;

[Route("Contact")]
public class ContactController : Controller
{
    private readonly IContactRepository _repo;

    public ContactController(IContactRepository repo)
    {
        _repo = repo;
    }

    [HttpGet("ShowContacts")]
    public IActionResult ShowContacts()
    {
        return View(_repo.GetAllContacts());
    }

    [HttpGet("AddContact")]
    public IActionResult AddContact()
    {
        ViewBag.Companies = _repo.GetCompanies();
        ViewBag.Departments = _repo.GetDepartments();
        return View();
    }

    [HttpPost("AddContact")]
    public IActionResult AddContact(ContactInfo contact)
    {
        _repo.AddContact(contact);
        return RedirectToAction("ShowContacts");
    }
}
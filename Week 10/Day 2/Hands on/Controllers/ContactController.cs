using Microsoft.AspNetCore.Mvc;
using ContactApi.Interfaces;
using ContactApi.Models;

namespace ContactApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ContactController : ControllerBase
{
    private readonly IContactService _service;

    public ContactController(IContactService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_service.GetAll());
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var data = _service.GetById(id);
        if (data == null) return NotFound();
        return Ok(data);
    }

    [HttpPost]
    public IActionResult Add(Contact contact)
    {
        _service.Add(contact);
        return Ok(contact);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Contact contact)
    {
        _service.Update(id, contact);
        return Ok(contact);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _service.Delete(id);
        return Ok();
    }
}
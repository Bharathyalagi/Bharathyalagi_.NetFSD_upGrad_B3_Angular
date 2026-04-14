using ContactCachingApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContactCachingApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ContactsController : ControllerBase
{
    private readonly IContactService service;

    public ContactsController(IContactService service)
    {
        this.service = service;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var result = service.FetchAll();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var result = service.FetchById(id);
        if (result == null) return NotFound();
        return Ok(result);
    }
}
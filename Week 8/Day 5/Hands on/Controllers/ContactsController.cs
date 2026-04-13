using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication8._5.Models;
using WebApplication8._5.Repositories;
using WebApplication8._5.Exceptions;

namespace WebApplication8._5.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ContactsController : ControllerBase
{
    private readonly IContactRepository _repo;
    private readonly ILogger<ContactsController> _logger;

    public ContactsController(IContactRepository repo, ILogger<ContactsController> logger)
    {
        _repo = repo;
        _logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await _repo.GetAllAsync());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var data = await _repo.GetByIdAsync(id);
        if (data == null)
            throw new NotFoundException("Contact not found");

        return Ok(data);
    }

    [HttpPost]
    public async Task<IActionResult> Post(ContactInfo contact)
    {
        await _repo.AddAsync(contact);
        _logger.LogInformation("Contact created");
        return Ok(contact);
    }

    [HttpPut]
    public async Task<IActionResult> Put(ContactInfo contact)
    {
        await _repo.UpdateAsync(contact);
        _logger.LogInformation("Contact updated");
        return Ok(contact);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _repo.DeleteAsync(id);
        _logger.LogInformation("Contact deleted");
        return Ok();
    }
}
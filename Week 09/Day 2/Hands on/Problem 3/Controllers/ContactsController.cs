using ContactRateLimitApi.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;

namespace ContactRateLimitApi.Controllers;

[Route("api/[controller]")]
[ApiController]
[EnableRateLimiting("limit")]
public class ContactsController : ControllerBase
{
    private readonly ContactStore store;

    public ContactsController(ContactStore store)
    {
        this.store = store;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var data = store.GetAll();
        return Ok(data);
    }
}
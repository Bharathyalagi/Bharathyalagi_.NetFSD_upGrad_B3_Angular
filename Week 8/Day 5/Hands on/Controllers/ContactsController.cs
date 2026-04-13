using Microsoft.AspNetCore.Mvc;
using WebApplication8._3.Models;
using WebApplication8._3.DataAccess;

namespace WebApplication8._3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactRepository _repo;

        public ContactsController(IContactRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _repo.GetAllAsync();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var contact = await _repo.GetByIdAsync(id);

            if (contact == null)
                return NotFound();

            return Ok(contact);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ContactInfo contact)
        {
            if (contact == null)
                return BadRequest();

            await _repo.AddAsync(contact);

            return CreatedAtAction(nameof(GetById),
                new { id = contact.ContactId },
                contact);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, ContactInfo contact)
        {
            var existing = await _repo.GetByIdAsync(id);

            if (existing == null)
                return NotFound();

            await _repo.UpdateAsync(id, contact);

            return Ok(contact);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var existing = await _repo.GetByIdAsync(id);

            if (existing == null)
                return NotFound();

            await _repo.DeleteAsync(id);

            return Ok("Deleted successfully");
        }
    }
}
using Microsoft.EntityFrameworkCore;
using ContactManagement.Data;
using ContactManagement.Models;

namespace ContactManagement.Repositories;

public class ContactRepository : IContactRepository
{
    private readonly AppDbContext _context;

    public ContactRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Contact>> GetAllAsync()
    {
        return await _context.Contacts.ToListAsync();
    }

    public async Task<Contact> GetByIdAsync(int id)
    {
        return await _context.Contacts.FindAsync(id);
    }

    public async Task AddAsync(Contact contact)
    {
        await _context.Contacts.AddAsync(contact);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Contact contact)
    {
        _context.Contacts.Update(contact);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var data = await _context.Contacts.FindAsync(id);
        if (data != null)
        {
            _context.Contacts.Remove(data);
            await _context.SaveChangesAsync();
        }
    }
}
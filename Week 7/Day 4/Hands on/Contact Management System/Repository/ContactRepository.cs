using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

public class ContactRepository : IContactRepository
{
    private readonly AppDbContext _context;

    public ContactRepository(AppDbContext context)
    {
        _context = context;
    }

    public List<ContactInfo> GetAllContacts()
    {
        return _context.Contacts
            .Include(c => c.Company)
            .Include(c => c.Department)
            .ToList();
    }

    public void AddContact(ContactInfo contact)
    {
        _context.Contacts.Add(contact);
        _context.SaveChanges();
    }

    public void DeleteContact(int id)
    {
        var data = _context.Contacts.Find(id);
        if (data != null)
        {
            _context.Contacts.Remove(data);
            _context.SaveChanges();
        }
    }
}
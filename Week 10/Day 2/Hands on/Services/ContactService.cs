using ContactApi.Interfaces;
using ContactApi.Models;

namespace ContactApi.Services;

public class ContactService : IContactService
{
    private List<Contact> contacts = new();

    public List<Contact> GetAll()
    {
        return contacts;
    }

    public Contact GetById(int id)
    {
        return contacts.FirstOrDefault(x => x.Id == id);
    }

    public void Add(Contact contact)
    {
        contact.Id = contacts.Count + 1;
        contacts.Add(contact);
    }

    public void Update(int id, Contact contact)
    {
        var existing = contacts.FirstOrDefault(x => x.Id == id);
        if (existing == null) throw new Exception("Not found");

        existing.Name = contact.Name;
        existing.Email = contact.Email;
        existing.Phone = contact.Phone;
    }

    public void Delete(int id)
    {
        var contact = contacts.FirstOrDefault(x => x.Id == id);
        if (contact == null) throw new Exception("Not found");

        contacts.Remove(contact);
    }
}
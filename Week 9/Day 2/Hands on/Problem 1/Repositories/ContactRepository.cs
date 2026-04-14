using ContactCachingApi.Models;

namespace ContactCachingApi.Repositories;

public class ContactRepository : IContactRepository
{
    private List<Contact> items = new List<Contact>
    {
        new Contact { ContactId = 1, Name = "Bharath", Email = "bharath@gmail.com" },
        new Contact { ContactId = 2, Name = "Bhuvan", Email = "bhuvan@gmail.com" },
        new Contact { ContactId = 3, Name = "Ramesh", Email = "ramesh@gmail.com" }
    };

    public List<Contact> GetAll()
    {
        return items;
    }

    public Contact GetById(int id)
    {
        return items.FirstOrDefault(x => x.ContactId == id);
    }
}
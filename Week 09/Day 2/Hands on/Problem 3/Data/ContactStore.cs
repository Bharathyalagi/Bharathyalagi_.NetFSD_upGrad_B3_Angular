using ContactRateLimitApi.Models;

namespace ContactRateLimitApi.Data;

public class ContactStore
{
    public List<Contact> GetAll()
    {
        return new List<Contact>
        {
            new Contact { ContactId = 1, Name = "Ravi", Email = "ravi@test.com", Phone = "9999999999" },
            new Contact { ContactId = 2, Name = "Meena", Email = "meena@test.com", Phone = "8888888888" }
        };
    }
}
using WebApplication3.Models;

public interface IContactRepository
{
    List<ContactInfo> GetAllContacts();
    void AddContact(ContactInfo contact);
    void DeleteContact(int id);
}
using ContactManagement.Models;

namespace ContactManagement.Interfaces
{
    public interface IContactService
    {
        void AddContact(Contact contact);
        List<Contact> GetAllContacts();
        Contact? GetContactById(int id);
        void UpdateContact(Contact contact);
        void DeleteContact(int id);
    }
}
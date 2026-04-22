using ContactManagement.Interfaces;
using ContactManagement.Models;
using ContactManagement.Utilities;
using ContactManagement.Utilities;

namespace ContactManagement.Services
{
    public class ContactService : IContactService
    {
        private readonly List<Contact> contacts = new();

        public void AddContact(Contact contact)
        {
            ValidationHelper.ValidateContact(contact);

            contact.Id = contacts.Count + 1;
            contacts.Add(contact);
        }

        public List<Contact> GetAllContacts()
        {
            return contacts;
        }

        public Contact? GetContactById(int id)
        {
            return contacts.FirstOrDefault(c => c.Id == id);
        }

        public void UpdateContact(Contact contact)
        {
            ValidationHelper.ValidateContact(contact);

            var existing = GetContactById(contact.Id);

            if (existing == null)
                throw new Exception("Contact not found");

            existing.Name = contact.Name;
            existing.Email = contact.Email;
            existing.Phone = contact.Phone;
        }

        public void DeleteContact(int id)
        {
            var contact = GetContactById(id);

            if (contact == null)
                throw new Exception("Contact not found");

            contacts.Remove(contact);
        }
    }
}
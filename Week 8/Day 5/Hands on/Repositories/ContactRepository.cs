using WebApplication8._3.Models;

namespace WebApplication8._3.DataAccess
{
    public class ContactRepository : IContactRepository
    {
        public static List<ContactInfo> contacts = new List<ContactInfo>();

        public async Task<IEnumerable<ContactInfo>> GetAllAsync()
        {
            return await Task.FromResult(contacts);
        }

        public async Task<ContactInfo> GetByIdAsync(int id)
        {
            var contact = contacts.FirstOrDefault(c => c.ContactId == id);
            return await Task.FromResult(contact);
        }

        public async Task AddAsync(ContactInfo contact)
        {
            contact.ContactId = contacts.Count + 1;
            contacts.Add(contact);
            await Task.CompletedTask;
        }

        public async Task UpdateAsync(int id, ContactInfo contact)
        {
            var existing = contacts.FirstOrDefault(c => c.ContactId == id);

            if (existing != null)
            {
                existing.FirstName = contact.FirstName;
                existing.LastName = contact.LastName;
                existing.EmailId = contact.EmailId;
                existing.MobileNo = contact.MobileNo;
                existing.Designation = contact.Designation;
                existing.CompanyId = contact.CompanyId;
                existing.DepartmentId = contact.DepartmentId;
            }

            await Task.CompletedTask;
        }

        public async Task DeleteAsync(int id)
        {
            var contact = contacts.FirstOrDefault(c => c.ContactId == id);
            if (contact != null)
            {
                contacts.Remove(contact);
            }

            await Task.CompletedTask;
        }
    }
}
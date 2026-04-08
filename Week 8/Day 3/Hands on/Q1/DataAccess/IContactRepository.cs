using WebApplication8._3.Models;

namespace WebApplication8._3.DataAccess
{
    public interface IContactRepository
    {
        Task<IEnumerable<ContactInfo>> GetAllAsync();
        Task<ContactInfo> GetByIdAsync(int id);
        Task AddAsync(ContactInfo contact);
        Task UpdateAsync(int id, ContactInfo contact);
        Task DeleteAsync(int id);
    }
}
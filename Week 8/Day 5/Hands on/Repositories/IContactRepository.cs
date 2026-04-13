using WebApplication8._5.Models;

namespace WebApplication8._5.Repositories;

public interface IContactRepository
{
    Task<List<ContactInfo>> GetAllAsync();
    Task<ContactInfo> GetByIdAsync(int id);
    Task AddAsync(ContactInfo contact);
    Task UpdateAsync(ContactInfo contact);
    Task DeleteAsync(int id);
}
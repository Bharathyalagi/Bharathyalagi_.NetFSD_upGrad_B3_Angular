using ContactCachingApi.Models;

namespace ContactCachingApi.Repositories;

public interface IContactRepository
{
    List<Contact> GetAll();
    Contact GetById(int id);
}
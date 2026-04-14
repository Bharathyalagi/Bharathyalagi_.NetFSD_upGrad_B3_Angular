using ContactCachingApi.Models;

namespace ContactCachingApi.Services;

public interface IContactService
{
    List<Contact> FetchAll();
    Contact FetchById(int id);
}
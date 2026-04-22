using ContactApi.Models;

namespace ContactApi.Interfaces;

public interface IContactService
{
    List<Contact> GetAll();
    Contact GetById(int id);
    void Add(Contact contact);
    void Update(int id, Contact contact);
    void Delete(int id);
}
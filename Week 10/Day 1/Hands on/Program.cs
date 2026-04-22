using ContactManagement.Models;
using ContactManagement.Services;

var service = new ContactService();

service.AddContact(new Contact
{
    Name = "Bharath",
    Email = "bharath@mail.com",
    Phone = "9998997890"
});

var contacts = service.GetAllContacts();

foreach (var c in contacts)
{
    Console.WriteLine($"{c.Id} {c.Name}");
}
using Xunit;
using NSubstitute;
using ContactService.Controllers;
using ContactService.Repositories;
using ContactService.Models;
using Microsoft.AspNetCore.Mvc;

public class ContactControllerTests
{
    private readonly IContactRepository _repo;
    private readonly ContactsController _controller;

    public ContactControllerTests()
    {
        _repo = Substitute.For<IContactRepository>();
        _controller = new ContactsController(_repo);
    }

    [Fact]
    public async Task GetAll_ReturnsOk()
    {
        var data = new List<Contact>
        {
            new Contact { ContactId = 1, Name = "A" },
            new Contact { ContactId = 2, Name = "B" }
        };

        _repo.GetAllAsync().Returns(data);

        var result = await _controller.GetAll();

        var ok = Assert.IsType<OkObjectResult>(result);
        var value = Assert.IsAssignableFrom<IEnumerable<Contact>>(ok.Value);

        Assert.Equal(2, value.Count());
    }

    [Fact]
    public async Task GetById_NotFound()
    {
        _repo.GetByIdAsync(1).Returns((Contact)null);

        var result = await _controller.GetById(1);

        Assert.IsType<NotFoundResult>(result);
    }
}
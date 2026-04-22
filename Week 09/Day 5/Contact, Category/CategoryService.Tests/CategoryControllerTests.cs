using Xunit;
using NSubstitute;
using CategoryService.Controllers;
using CategoryService.Repositories;
using CategoryService.Models;
using Microsoft.AspNetCore.Mvc;

public class CategoryControllerTests
{
    private readonly ICategoryRepository _repo;
    private readonly CategoriesController _controller;

    public CategoryControllerTests()
    {
        _repo = Substitute.For<ICategoryRepository>();
        _controller = new CategoriesController(_repo);
    }

    [Fact]
    public async Task GetAll_ReturnsOk()
    {
        var data = new List<Category>
        {
            new Category { CategoryId = 1, CategoryName = "Tech" }
        };

        _repo.GetAllAsync().Returns(data);

        var result = await _controller.GetAll();

        var ok = Assert.IsType<OkObjectResult>(result);
        Assert.NotNull(ok.Value);
    }
}
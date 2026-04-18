using Xunit;
using NSubstitute;
using Microsoft.AspNetCore.Mvc;
using WebApplication26.Controllers;
using WebApplication26.Repositories;
using WebApplication26.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace WebApplication26.Tests
{
    public class ProductControllerTests
    {
        private readonly IProductRepository repo;
        private readonly ProductsController ctrl;

        public ProductControllerTests()
        {
            repo = Substitute.For<IProductRepository>();
            ctrl = new ProductsController(repo);
        }

        [Fact]
        public async Task get_all_returns_ok()
        {
            var data = new List<Product>
            {
                new Product { Id = 1, Name = "pen", Price = 10 },
                new Product { Id = 2, Name = "book", Price = 50 }
            };

            repo.GetAllAsync().Returns(data);

            var result = await ctrl.GetAll();

            var ok = Assert.IsType<OkObjectResult>(result);
            var list = Assert.IsAssignableFrom<IEnumerable<Product>>(ok.Value);

            Assert.Equal(2, list.Count());
        }

        [Fact]
        public async Task get_by_id_not_found()
        {
            repo.GetByIdAsync(1).Returns((Product)null);

            var result = await ctrl.GetById(1);

            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async Task create_returns_created()
        {
            var item = new Product { Id = 1, Name = "bag", Price = 100 };

            repo.AddAsync(item).Returns(item);

            var result = await ctrl.Create(item);

            var created = Assert.IsType<CreatedAtActionResult>(result);
            var value = Assert.IsType<Product>(created.Value);

            Assert.Equal("bag", value.Name);
        }

        [Fact]
        public async Task delete_returns_no_content()
        {
            repo.DeleteAsync(1).Returns(true);

            var result = await ctrl.Delete(1);

            Assert.IsType<NoContentResult>(result);
        }
    }
}
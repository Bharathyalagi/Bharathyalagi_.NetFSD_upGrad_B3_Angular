using ShopEz.API.Models;
using ShopEz.API.Repositories;

namespace ShopEz.API.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;

        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _repo.GetAll();
        }

        public async Task<Product?> GetProductById(int id)
        {
            return await _repo.GetById(id);
        }

        public async Task AddProduct(Product product)
        {
            if (string.IsNullOrWhiteSpace(product.Name))
                throw new Exception("Product name is required");

            if (product.Price <= 0)
                throw new Exception("Price must be greater than zero");

            if (product.Stock < 0)
                throw new Exception("Stock cannot be negative");

            await _repo.Add(product);
        }

        public async Task UpdateProduct(Product product)
        {
            if (product.ProductId <= 0)
                throw new Exception("Invalid product id");

            if (string.IsNullOrWhiteSpace(product.Name))
                throw new Exception("Product name is required");

            if (product.Price <= 0)
                throw new Exception("Price must be greater than zero");

            await _repo.Update(product);
        }

        public async Task DeleteProduct(int id)
        {
            if (id <= 0)
                throw new Exception("Invalid product id");

            await _repo.Delete(id);
        }
    }
}
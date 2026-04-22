using WebApplication2.Models;

namespace WebApplication2.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
        void AddProduct(Product product);
    }
}
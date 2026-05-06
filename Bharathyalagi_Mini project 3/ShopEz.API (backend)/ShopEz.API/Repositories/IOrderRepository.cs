using ShopEz.API.Models;
using ShopEz.API.Models;

namespace ShopEz.API.Repositories
{
    public interface IOrderRepository
    {
        Task AddOrder(Order order);
        Task<List<Order>> GetAll();
        Task<Order?> GetById(int id);
    }
}
using ShopEz.API.DTOs;
using ShopEz.API.Models;
using ShopEz.API.DTOs;
using ShopEz.API.Models;

namespace ShopEz.API.Services
{
    public interface IOrderService
    {
        Task<Order> CreateOrder(OrderDTO dto);
        Task<List<Order>> GetAllOrders();
        Task<Order?> GetOrderById(int id);
    }
}
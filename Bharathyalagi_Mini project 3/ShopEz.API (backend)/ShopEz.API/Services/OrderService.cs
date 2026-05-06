using ShopEz.API.Data;
using ShopEz.API.DTOs;
using ShopEz.API.Models;
using ShopEz.API.Repositories;
using ShopEz.API.Services;
using ShopEz.API.Data;
using ShopEz.API.DTOs;
using ShopEz.API.Models;
using ShopEz.API.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ShopEz.API.Services
{
    public class OrderService : IOrderService
    {
        private readonly ApplicationDbContext _context;
        private readonly IOrderRepository _orderRepo;

        public OrderService(ApplicationDbContext context, IOrderRepository orderRepo)
        {
            _context = context;
            _orderRepo = orderRepo;
        }

        public async Task<Order> CreateOrder(OrderDTO dto)
        {
            if (dto.Items == null || !dto.Items.Any())
                throw new Exception("Cart is empty");

            var productIds = dto.Items.Select(x => x.ProductId).ToList();

            var products = await _context.Products
                .Where(p => productIds.Contains(p.ProductId))
                .ToListAsync();

            if (products.Count != productIds.Count)
                throw new Exception("Some products not found");

            var orderItems = new List<OrderItem>();
            decimal total = 0;

            foreach (var item in dto.Items)
            {
                var product = products.First(p => p.ProductId == item.ProductId);

                if (item.Quantity <= 0)
                    throw new Exception("Invalid quantity");

                var orderItem = new OrderItem
                {
                    ProductId = product.ProductId,
                    Quantity = item.Quantity,
                    Price = product.Price
                };

                total += product.Price * item.Quantity;
                orderItems.Add(orderItem);
            }

            var order = new Order
            {
                UserId = dto.UserId,
                OrderDate = DateTime.Now,
                TotalAmount = total,
                OrderItems = orderItems
            };

            await _orderRepo.AddOrder(order);

            return order;
        }

        public async Task<List<Order>> GetAllOrders()
        {
            return await _orderRepo.GetAll();
        }

        public async Task<Order?> GetOrderById(int id)
        {
            return await _orderRepo.GetById(id);
        }
    }
}
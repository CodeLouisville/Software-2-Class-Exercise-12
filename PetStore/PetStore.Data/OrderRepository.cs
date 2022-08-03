using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Data
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ProductContext _dbContext;

        public OrderRepository()
        {
            _dbContext = new ProductContext();
        }

        public async Task<Order> GetOrderAsync(int id)
        {
            return await _dbContext.Orders.Include(x=>x.Products).SingleOrDefaultAsync(x=>x.OrderId == id);
        }

        public async Task AddOrderAsync(Order order)
        {
            await _dbContext.Orders.AddAsync(order);
            await _dbContext.SaveChangesAsync();
        }
    }
}

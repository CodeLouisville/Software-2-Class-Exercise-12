using PetStore.Data;
using PetStore.Logic;
using PetStore.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    public class ProductLogic : IProductLogic
    {
        private readonly IProductRepository _productRepo;
        private readonly IOrderRepository _orderRepo;

        public ProductLogic(IProductRepository productRepository, IOrderRepository orderRepository)
        {
            _productRepo = productRepository;
            _orderRepo = orderRepository;
        }

        public async Task AddProductAsync(Product product)
        {
            var validator = new ProductValidator();
            if (validator.Validate(product).IsValid)
            {
                await _productRepo.AddProductAsync(product);
            }
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _productRepo.GetAllProductsAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _productRepo.GetProductByIdAsync(id);
        }

        public async Task AddOrderAsync(Order order)
        {
            await _orderRepo.AddOrderAsync(order);
        }

        public async Task<Order> GetOrderAsync(int id)
        {
            return await _orderRepo.GetOrderAsync(id);
        }
    }
}

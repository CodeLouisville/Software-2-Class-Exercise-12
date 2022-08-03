using PetStore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Logic
{
    public interface IProductLogic
    {
        /// <summary>
        /// Add a product to the stores inventory
        /// </summary>
        /// <param name="product">The product that will be added.  It can be a derived type of Product</param>
        public Task AddProductAsync(Product product);

        /// <summary>
        /// Get all the products for the store
        /// </summary>
        public Task<List<Product>> GetAllProductsAsync();

        /// <summary>
        /// Gets a product by the id of the product
        /// </summary>
        /// <param name="productId">The id given to the product.</param>
        public Task<Product> GetProductByIdAsync(int productId);

        /// <summary>
        /// Add an order with products
        /// </summary>
        /// <param name="order">The order object</param>
        public Task AddOrderAsync(Order order);

        /// <summary>
        /// Get an order by its ID
        /// </summary>
        /// <param name="id">The key for the object</param>
        /// <returns>The order</returns>
        public Task<Order> GetOrderAsync(int id);
    }
}

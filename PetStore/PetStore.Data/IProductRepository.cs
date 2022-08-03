namespace PetStore.Data
{
    public interface IProductRepository
    {
        Task AddProductAsync(Product product);
        Task<Product> GetProductByIdAsync(int productId);

        Task<List<Product>> GetAllProductsAsync();
    }
}
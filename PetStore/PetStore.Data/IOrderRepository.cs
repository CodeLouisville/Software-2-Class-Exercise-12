namespace PetStore.Data
{
    public interface IOrderRepository
    {
        Task AddOrderAsync(Order order);
        Task<Order> GetOrderAsync(int id);
    }
}
using BeED.Models;

namespace BeED.Interfaces
{
    public interface IProduct
    {
        Task<EntityResult<Product>> GetAllProduct();
    }
}

using TheMenu.Domain.Entities;

namespace TheMenu.Domain.Interfaces.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts(bool trackChanges);
    }
}

using TheMenu.Domain.Entities;

namespace TheMenu.Domain.Interfaces.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts(bool trackChanges);
    }
}

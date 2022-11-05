using TheMenu.Domain.Entities;

namespace TheMenu.Domain.Interfaces.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts(Guid categoryId, bool trackChanges);
        Product? GetProduct(Guid categoryId, Guid productId, bool trackChanges);
    }
}

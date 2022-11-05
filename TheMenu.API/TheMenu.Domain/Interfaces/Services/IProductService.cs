using TheMenu.Domain.DTOs;

namespace TheMenu.Domain.Interfaces.Services
{
    public interface IProductService
    {
        IEnumerable<ProductDTO> GetAllProducts(Guid categoryId, bool trackChanges);
        ProductDTO GetProduct(Guid categoryId, Guid productId, bool trackChanges);
    }
}

using TheMenu.Domain.DTOs;

namespace TheMenu.Domain.Interfaces.Services
{
    public interface IProductService
    {
        IEnumerable<ProductDTO> GetAllProducts(bool trackChanges);
    }
}

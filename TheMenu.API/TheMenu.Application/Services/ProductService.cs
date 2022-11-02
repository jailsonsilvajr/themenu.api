using TheMenu.Domain.Entities;
using TheMenu.Domain.Interfaces.Repositories;
using TheMenu.Domain.Interfaces.Services;

namespace TheMenu.Application.Services
{
    internal sealed class ProductService : IProductService
    {
        private readonly IRepositoryManager _repositoryManager;

        public ProductService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public IEnumerable<Product> GetAllProducts(bool trackChanges)
        {
            try
            {
                var products = _repositoryManager.ProductRepository.GetAllProducts(trackChanges);
                return products;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

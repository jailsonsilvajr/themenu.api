using AutoMapper;
using TheMenu.Domain.DTOs;
using TheMenu.Domain.Entities.Exceptions;
using TheMenu.Domain.Interfaces.Repositories;
using TheMenu.Domain.Interfaces.Services;

namespace TheMenu.Application.Services
{
    internal sealed class ProductService : IProductService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public ProductService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public IEnumerable<ProductDTO> GetAllProducts(Guid categoryId, bool trackChanges)
        {
            CheckCategory(categoryId);

            var products = _repositoryManager.ProductRepository.GetAllProducts(categoryId, trackChanges);
            return _mapper.Map<IEnumerable<ProductDTO>>(products);
        }

        public ProductDTO GetProduct(Guid categoryId, Guid productId, bool trackChanges)
        {
            CheckCategory(categoryId);

            var product = _repositoryManager.ProductRepository.GetProduct(categoryId, productId, trackChanges);
            if (product is null) throw new ProductNotFoundException(productId);

            return _mapper.Map<ProductDTO>(product);
        }

        private void CheckCategory(Guid categoryId)
        {
            var category = _repositoryManager.CategoryRepository.GetCategoryById(categoryId, false);
            if (category is null) throw new CategoryNotFoundException(categoryId);
        }
    }
}

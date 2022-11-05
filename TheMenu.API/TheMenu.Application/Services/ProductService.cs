using AutoMapper;
using TheMenu.Domain.DTOs;
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

        public IEnumerable<ProductDTO> GetAllProducts(bool trackChanges)
        {
            var products = _repositoryManager.ProductRepository.GetAllProducts(trackChanges);
            return _mapper.Map<IEnumerable<ProductDTO>>(products);
        }
    }
}

using AutoMapper;
using TheMenu.Domain.Interfaces.Repositories;
using TheMenu.Domain.Interfaces.Services;

namespace TheMenu.Application.Services
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IProductService> _productService;
        private readonly Lazy<ICategoryService> _categoryService;

        public ServiceManager(
            IMapper mapper, 
            IRepositoryManager repositoryManager)
        {
            _productService = new Lazy<IProductService>(() => new ProductService(repositoryManager, mapper));
            _categoryService = new Lazy<ICategoryService>(() => new CategoryService(repositoryManager, mapper));
        }

        public IProductService ProductService => _productService.Value;
        public ICategoryService CategoryService => _categoryService.Value;
    }
}

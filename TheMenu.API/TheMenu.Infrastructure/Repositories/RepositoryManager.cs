using TheMenu.Domain.Interfaces.Repositories;
using TheMenu.Infrastructure.Context;

namespace TheMenu.Infrastructure.Repositories
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<IProductRepository> _productRepository;
        private readonly Lazy<ICategoryRepository> _categoryRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _productRepository = new Lazy<IProductRepository>(() => new ProductRepository(repositoryContext));
            _categoryRepository = new Lazy<ICategoryRepository>(() => new CategoryRepository(repositoryContext));
        }

        public IProductRepository ProductRepository => _productRepository.Value;
        public ICategoryRepository CategoryRepository => _categoryRepository.Value;

        public void Save()
        {
            _repositoryContext.SaveChanges();
        }
    }
}

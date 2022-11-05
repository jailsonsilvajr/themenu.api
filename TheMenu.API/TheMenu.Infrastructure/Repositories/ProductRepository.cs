using TheMenu.Domain.Entities;
using TheMenu.Domain.Interfaces.Repositories;
using TheMenu.Infrastructure.Context;

namespace TheMenu.Infrastructure.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext repositoryContext) : base(repositoryContext) { }

        public IEnumerable<Product> GetAllProducts(Guid categoryId, bool trackChanges) => 
            FindByCondition(p => p.CategoryId.Equals(categoryId), trackChanges)
            .OrderBy(p => p.Name)
            .ToList();

        public Product? GetProduct(Guid categoryId, Guid productId, bool trackChanges) =>
            FindByCondition(p => p.CategoryId.Equals(categoryId) && p.Id.Equals(productId), trackChanges)
            .SingleOrDefault();
    }
}

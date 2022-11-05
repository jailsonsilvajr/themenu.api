using Microsoft.EntityFrameworkCore;
using TheMenu.Domain.Entities;
using TheMenu.Domain.Interfaces.Repositories;
using TheMenu.Infrastructure.Context;

namespace TheMenu.Infrastructure.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext repositoryContext) : base(repositoryContext) { }

        public IEnumerable<Product> GetAllProducts(bool trackChanges) => 
            FindAll(trackChanges)
            .Include(p => p.Category)
            .OrderBy(p => p.Name)
            .ToList();
    }
}

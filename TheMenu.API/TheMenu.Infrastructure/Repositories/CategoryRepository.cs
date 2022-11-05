using TheMenu.Domain.Entities;
using TheMenu.Domain.Interfaces.Repositories;
using TheMenu.Infrastructure.Context;

namespace TheMenu.Infrastructure.Repositories
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<Category> GetAllCategories(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToList();
    }
}

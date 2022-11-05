using TheMenu.Domain.Entities;

namespace TheMenu.Domain.Interfaces.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories(bool trackChanges);
        Category? GetCategoryById(Guid categoryId, bool trackChanges);
    }
}

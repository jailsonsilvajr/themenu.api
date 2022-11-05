using TheMenu.Domain.DTOs;

namespace TheMenu.Domain.Interfaces.Services
{
    public interface ICategoryService
    {
        IEnumerable<CategoryDTO> GetAllCategories(bool trackChanges);
        CategoryDTO GetCategoryById(Guid categoryId, bool trackChanges);
    }
}

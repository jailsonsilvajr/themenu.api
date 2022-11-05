using AutoMapper;
using TheMenu.Domain.DTOs;
using TheMenu.Domain.Entities.Exceptions;
using TheMenu.Domain.Interfaces.Repositories;
using TheMenu.Domain.Interfaces.Services;

namespace TheMenu.Application.Services
{
    internal sealed class CategoryService : ICategoryService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public CategoryService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public IEnumerable<CategoryDTO> GetAllCategories(bool trackChanges)
        {
            var categories = _repositoryManager.CategoryRepository.GetAllCategories(trackChanges);
            return _mapper.Map<IEnumerable<CategoryDTO>>(categories);
        }

        public CategoryDTO GetCategoryById(Guid categoryId, bool trackChanges)
        {
            var category = _repositoryManager.CategoryRepository.GetCategoryById(categoryId, trackChanges);
            if (category is null) throw new CategoryNotFoundException(categoryId);

            return _mapper.Map<CategoryDTO>(category);
        }
    }
}

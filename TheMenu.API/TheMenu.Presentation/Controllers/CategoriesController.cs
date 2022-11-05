using Microsoft.AspNetCore.Mvc;
using TheMenu.Domain.Interfaces.Services;

namespace TheMenu.Presentation.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public CategoriesController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        public IActionResult GetCategories()
        {
            var categories = _serviceManager.CategoryService.GetAllCategories(trackChanges: false);
            return Ok(categories);
        }

        [HttpGet("{categoryId:guid}")]
        public IActionResult GetCategory(Guid categoryId)
        {
            var category = _serviceManager.CategoryService.GetCategoryById(categoryId, trackChanges: false);
            return Ok(category);
        }
    }
}

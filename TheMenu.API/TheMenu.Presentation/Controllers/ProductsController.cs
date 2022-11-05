using Microsoft.AspNetCore.Mvc;
using TheMenu.Domain.Interfaces.Services;

namespace TheMenu.Presentation.Controllers
{
    [Route("api/categories/{categoryId}/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public ProductsController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        public IActionResult GetProducts(Guid categoryId)
        {
            var products = _serviceManager.ProductService.GetAllProducts(categoryId, trackChanges: false);
            return Ok(products);
        }
    }
}

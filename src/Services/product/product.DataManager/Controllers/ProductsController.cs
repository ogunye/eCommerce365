using Microsoft.AspNetCore.Mvc;
using product.Service.Contracts;

namespace product.DataManager.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController: ControllerBase
    {
        private readonly IServiceManager _service;

        public ProductsController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetCategories()
        {
                var categories = _service.ProductCategoryService.GetAllProductCategory(trackChanges: false);
                return Ok(categories);
            }
    }
}

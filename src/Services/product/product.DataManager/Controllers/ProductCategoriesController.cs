using Microsoft.AspNetCore.Mvc;
using product.Service.Contracts;

namespace product.DataManager.Controllers
{
    [Route("api/product_categories")]
    [ApiController]
    public class ProductCategoriesController : ControllerBase
    {
        private readonly IServiceManager _service;

        public ProductCategoriesController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetCategories()
        {
            var categories = _service.ProductCategoryService.GetAllProductCategory(trackChanges: false);
            return Ok(categories);
        }

        [HttpGet("{Id:int}", Name ="ProductCategoryById")]
        public IActionResult GetProductCategory(int Id)
        {
            var category = _service.ProductCategoryService.GetProductCategory(Id, trackChanges: false);
            return Ok(category);
        }
    }
}

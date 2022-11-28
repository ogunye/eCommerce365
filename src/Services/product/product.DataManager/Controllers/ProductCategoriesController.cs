using Microsoft.AspNetCore.Mvc;
using product.Service.Contracts;
using product.Shared.DataTransferObjects;

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
        
        [HttpPost]
        public IActionResult CreateProductCategory([FromBody] ProductCategoryForCreationDto categoryForCreation)
        {
            if (categoryForCreation is null)
                return BadRequest("ProductCategoryForCreationDto object is null");

            var createCategory = _service.ProductCategoryService.CreateProductCategory(categoryForCreation);

            return CreatedAtRoute("ProductCategoryById", new { id = createCategory.Id });
        }
        
    
    }
}

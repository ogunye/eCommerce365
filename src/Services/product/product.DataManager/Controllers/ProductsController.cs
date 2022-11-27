using Microsoft.AspNetCore.Mvc;
using product.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product.DataManager.Controllers
{
    [Route("api/product_categories/{categoryId}/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IServiceManager _service;

        public ProductsController(IServiceManager service) => _service = service;

        [HttpGet]
        public IActionResult GetProductsForCategory(int categoryId)
        {
            var products = _service.ProductService.GetProducts(categoryId, trackChanges: false);
            return Ok(products);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetProductInCategoryById(int categoryId, int id)
        {
            var product = _service.ProductService.GetProductById(categoryId, id, trackChanges: false);
            return Ok(product);
        }
    }
}

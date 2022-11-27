using AutoMapper;
using product.Application.Contracts;
using product.Domain.Exceptions;
using product.Service.Contracts;
using product.Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product.Service.ServiceRepository
{
    internal sealed class ProductService : IProductService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ProductService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public ProductDto GetProductById(int categoryId, int Id, bool trackChanges)
        {
            var category = _repository.ProductCategory.GetProductCategory(categoryId, trackChanges);
            if(category is null)
                throw new ProductCategoryNotFoundException(categoryId);

            var product = _repository.Product.GetProduct(category.Id, Id, trackChanges);

            if(product is null)
                throw new ProductNotFoundException(Id);

            var productFromDb = _mapper.Map<ProductDto>(product);
            return productFromDb;
        }

        public IEnumerable<ProductDto> GetProducts(int categoryId, bool trackChanges)
        {
            var category = _repository.ProductCategory.GetProductCategory(categoryId, trackChanges);

            if (category is null)
                throw new ProductCategoryNotFoundException(categoryId);

            var productsFromDb = _repository.Product.GetAllProducts(categoryId, trackChanges);
            var productsDto = _mapper.Map<IEnumerable<ProductDto>>(productsFromDb);

            return productsDto;
        }
    }
}

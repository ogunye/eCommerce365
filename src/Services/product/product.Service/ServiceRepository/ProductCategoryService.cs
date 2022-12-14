using AutoMapper;
using product.Application.Contracts;
using product.Domain.Exceptions;
using product.Domain.Models;
using product.Service.Contracts;
using product.Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product.Service.ServiceRepository
{
    internal sealed class ProductCategoryService : IProductCategoryService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ProductCategoryService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public ProductCategoryDto CreateProductCategory(ProductCategoryForCreationDto productCategory)
        {
            var categoryEntity = _mapper.Map<ProductCategory>(productCategory);

            _repository.ProductCategory.CreateProductCategory(categoryEntity);
            _repository.Save();

            var categoryToReturn = _mapper.Map<ProductCategoryDto>(categoryEntity);
            return categoryToReturn;
        }

        public IEnumerable<ProductCategoryDto> GetAllProductCategory(bool trackChanges)
        {
            var categories = _repository.ProductCategory.GetAllProductCategories(trackChanges);
            var categoriesDto = _mapper.Map<IEnumerable<ProductCategoryDto>>(categories);
            return categoriesDto;
        }

        public ProductCategoryDto GetProductCategory(int Id, bool trackChanges)
        {
            var category = _repository.ProductCategory.GetProductCategory(Id, trackChanges);

            if (category is null)
                throw new ProductCategoryNotFoundException(Id);

            var categoryDto = _mapper.Map<ProductCategoryDto>(category);
            return categoryDto;
        }
    }
}

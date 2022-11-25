using AutoMapper;
using product.Application.Contracts;
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

        public IEnumerable<ProductCategoryDto> GetAllProductCategory(bool trackChanges)
        {
            try
            {
                var categories = _repository.ProductCategory.GetAllProductCategories(trackChanges);
                var categoriesDto = _mapper.Map<IEnumerable<ProductCategoryDto>>(categories);
                return categoriesDto;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetAllProductCategory)} service method{ex}");
                throw;
            }
        }
    }
}

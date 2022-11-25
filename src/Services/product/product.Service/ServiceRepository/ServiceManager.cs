using AutoMapper;
using product.Application.Contracts;
using product.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product.Service.ServiceRepository
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IProductService> _productService;
        private readonly Lazy<IProductCategoryService> _productCategoryService;

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _productService = new Lazy<IProductService>(()=> new ProductService(repositoryManager, logger, mapper));
            _productCategoryService = new Lazy<IProductCategoryService>(() => new ProductCategoryService(repositoryManager, logger, mapper));
        }

        public IProductCategoryService ProductCategoryService => _productCategoryService.Value;

        public IProductService ProductService => _productService.Value;
    }
}

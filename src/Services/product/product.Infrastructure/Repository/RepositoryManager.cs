using product.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product.Infrastructure.Repository
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<IProductRepository> _productRepository;
        private readonly Lazy<IProductCategoryRepository> _categoryRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _productRepository = new Lazy<IProductRepository>(()=> new ProductRepository(repositoryContext));
            _categoryRepository = new Lazy<IProductCategoryRepository>(()=> new ProductCategoryRepsitory(repositoryContext));
        }
        public IProductRepository Product => _productRepository.Value;

        public IProductCategoryRepository ProductCategory => _categoryRepository.Value;

        public void Save() => _repositoryContext.SaveChanges();
    }
}

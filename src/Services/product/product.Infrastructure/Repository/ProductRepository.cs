using product.Application.Contracts;
using product.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product.Infrastructure.Repository
{
    internal sealed class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<Product> GetAllProducts(int productCategoryId, bool trackChanges) => FindByCondition(p => p.productCategoryId.Equals(productCategoryId), trackChanges)
                .OrderBy(p => p.ProductCategory.CategoryName).ToList();

        public Product GetProduct(int categoryId, int Id, bool trackChanges) =>
            FindByCondition(c => c.productCategoryId.Equals(categoryId) && c.Id.Equals(Id), trackChanges).SingleOrDefault();
    }
}

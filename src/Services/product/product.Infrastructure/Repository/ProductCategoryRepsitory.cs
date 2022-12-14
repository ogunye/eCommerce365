using product.Application.Contracts;
using product.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product.Infrastructure.Repository
{
    internal sealed class ProductCategoryRepsitory : RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepsitory(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateProductCategory(ProductCategory category) => Create(category);

        public IEnumerable<ProductCategory> GetAllProductCategories(bool trackChanges) => FindAll(trackChanges)
                .OrderBy(x => x.Id)
                .ToList();

        public ProductCategory GetProductCategory(int Id, bool trackChanges) =>
            FindByCondition(c => c.Id.Equals(Id), trackChanges).SingleOrDefault();
        
    }
}

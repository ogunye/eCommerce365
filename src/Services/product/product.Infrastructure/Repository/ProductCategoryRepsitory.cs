using product.Application.Contracts;
using product.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product.Infrastructure.Repository
{
    public class ProductCategoryRepsitory : RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepsitory(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}

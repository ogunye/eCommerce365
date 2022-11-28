using product.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product.Application.Contracts
{
    public interface IProductCategoryRepository
    {
        IEnumerable<ProductCategory> GetAllProductCategories(bool trackChanges);
        ProductCategory GetProductCategory(int Id, bool trackChanges);
        void CreateProductCategory(ProductCategory category);
    }
}

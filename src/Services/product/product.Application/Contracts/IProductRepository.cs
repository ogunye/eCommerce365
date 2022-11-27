using product.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product.Application.Contracts
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts(int productCategoryId, bool trackChanges);
        Product GetProduct(int categoryId, int Id, bool trackChanges);
    }
}

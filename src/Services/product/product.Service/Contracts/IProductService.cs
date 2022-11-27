using product.Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product.Service.Contracts
{
    public interface IProductService
    {
        IEnumerable<ProductDto> GetProducts(int categoryId, bool trackChanges);
        ProductDto GetProductById(int categoryId, int Id, bool trackChanges);
    }
}

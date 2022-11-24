using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product.Application.Contracts
{
    public interface IRepositoryManager
    {
        IProductRepository Product { get; }
        IProductCategoryRepository ProductCategory { get; }
        void Save();
    }
}

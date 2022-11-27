using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product.Domain.Exceptions
{
    public sealed class ProductCategoryNotFoundException : NotFoundException
    {
        public ProductCategoryNotFoundException(int Id)
            : base($"The ProductCategory with id: {Id} doesn't exist in the database.")
        {  }
    }
}

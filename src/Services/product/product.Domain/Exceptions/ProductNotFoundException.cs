using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product.Domain.Exceptions
{
    public class ProductNotFoundException : NotFoundException
    {
        public ProductNotFoundException(int productId)
            : base($"Product with Id: {productId} doesn't exist in the database.")
        {
        }
    }
}

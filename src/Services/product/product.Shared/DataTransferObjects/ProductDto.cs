using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product.Shared.DataTransferObjects
{
    public record  ProductDto(int Id, string productName, string productDescription, string productCategoryId, decimal unitPrice );
    
}

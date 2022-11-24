﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product.Service.Contracts
{
    public interface IServiceManager
    {
        IProductCategoryService ProductCategoryService { get; }
        IProductService ProductService { get; }
    }
}

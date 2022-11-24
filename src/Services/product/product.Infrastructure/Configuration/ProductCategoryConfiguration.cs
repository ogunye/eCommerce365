using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using product.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product.Infrastructure.Configuration
{
    public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasData
                (
                    new ProductCategory { Id = 1, CategoryName = "Drink", CategoryDescription = "All types of drinks including wine, brande, etc", },
                    new ProductCategory { Id = 2, CategoryName = "Provisions", CategoryDescription = "Consumerable or eddiable items" }
                );
        }
    }
}

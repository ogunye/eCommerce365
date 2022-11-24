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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData
                (
                    new Product { Id = 1, productName = "Coke-Cola", productDescription = "carbonate drink", productCategoryId = 1, unitPrice = 200 },
                    new Product { Id = 2, productName = "Pescp-Cola", productDescription = "carbonate drink", productCategoryId = 1, unitPrice = 200 },
                    new Product { Id = 3, productName = "Fanta", productDescription = "carbonate drink", productCategoryId = 1, unitPrice = 200 },
                    new Product { Id = 4, productName = "Gulder-beer", productDescription = "Alcohol drink", productCategoryId = 1, unitPrice = 200 },
                    new Product { Id = 5, productName = "Red-Label", productDescription = "Brande", productCategoryId = 1, unitPrice = 200 }
                );
        }
    }
}

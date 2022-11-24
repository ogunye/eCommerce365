using product.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product.Domain.Models
{
    public class Product : BaseEntity
    {
        [Required(ErrorMessage ="Product name is a required field.")]
        [StringLength(100, ErrorMessage ="Maxinum length for product name is 100")]
        [Column("ProductName")]
        public string? productName { get; set; }

        [StringLength(300, ErrorMessage = "Maxinum length for product name is 300")]
        [Column("ProductDescription")]
        public string? productDescription { get; set; }


        [ForeignKey(nameof(ProductCategory))]
        [Column("CategoryId")]
        public int productCategoryId { get; set; }

        [Required(ErrorMessage ="Unit Price is a required field.")]
        [Column(TypeName ="decimal(18,6)")]
        public decimal unitPrice { get; set; }

        public ProductCategory? ProductCategory { get; set; }
    }
}

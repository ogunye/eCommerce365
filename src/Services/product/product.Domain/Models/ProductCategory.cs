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
    public class ProductCategory : BaseEntity
    {
        [Required(ErrorMessage ="Category Name is a required field.")]
        [StringLength(100, ErrorMessage ="Maximum length of Category Name is 100")]
        public string? CategoryName { get; set; }

        [StringLength(400, ErrorMessage = "Maximum length of Category Name is 400")]
        public string? CategoryDescription { get; set; }

        public ICollection<Product>? Products { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestApis.Models
{
    public class ProductForSave
    {
        [Required]
        [StringLength(50,MinimumLength =5)]
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }

        public Product ToProduct()
        {
            return new Product
            {
                Name = Name,
                Description = Description,
                Price = Price,
                CategoryId = CategoryId,
                SupplierId = SupplierId
            };
        }
    }
}

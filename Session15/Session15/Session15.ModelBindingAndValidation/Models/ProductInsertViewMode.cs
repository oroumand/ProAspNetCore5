using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Session15.ModelBindingAndValidation.Models
{
    public class ProductInsertViewMode
    {
        [Remote("IsVali","Product",ErrorMessage = "Ghabool nist")]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }
    }
}

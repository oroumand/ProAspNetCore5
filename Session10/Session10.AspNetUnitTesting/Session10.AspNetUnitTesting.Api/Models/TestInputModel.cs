using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Session10.AspNetUnitTesting.Api.Models
{
    public class TestInputModel
    {
        [Required(ErrorMessage = "FirstName Required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName Required")]
        public string LastName { get; set; }
    }
}

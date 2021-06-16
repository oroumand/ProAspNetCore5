using Microsoft.AspNetCore.Mvc;
using Session15.ModelBindingAndValidation.Infrastructures;

namespace Session15.ModelBindingAndValidation.Models
{
    public class Category
    {
        //[BindNever]
        public int Id { get; set; }
        [ModelBinder(typeof(ToUpperModerBinder))]
        public string Name { get; set; }
    }
}

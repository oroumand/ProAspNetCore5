using Microsoft.AspNetCore.Mvc;
using Session15.ModelBindingAndValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session15.ModelBindingAndValidation.Controlles
{
    public class CategoryController : Controller
    {
        private readonly ProductContext _productContext;

        public CategoryController(ProductContext productContext)
        {
            _productContext = productContext;
        }
        public IActionResult Index(int id=1)
        {
            var category = _productContext.Categories.Single(c => c.Id == id);
            return View(category);
        }

        public IActionResult IndexQuery([FromQuery]int id=1)
        {
            var category = _productContext.Categories.Single(c => c.Id == id);
            return View("Index",category);
        }

        [HttpPost]
        public async Task< IActionResult> SaveCategory()
        {
            var category = new Category();
            await TryUpdateModelAsync<Category>(category);
            _productContext.Categories.Add(category);
            _productContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

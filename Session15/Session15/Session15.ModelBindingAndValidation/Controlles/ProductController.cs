using Microsoft.AspNetCore.Mvc;
using Session15.ModelBindingAndValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session15.ModelBindingAndValidation.Controlles
{
    public class ProductController : Controller
    {
        private readonly ProductContext _dbContext;

        public ProductController(ProductContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            //var productList = _dbContext.Products.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult SaveProduct(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        //public IActionResult SaveCategory([Bind("Name", Prefix = "AlirezaOroumand")] Category category)
        public IActionResult SaveCategory([Bind(Prefix = "AlirezaOroumand")] Category category)
        {
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Insert(ProductInsertViewMode product)
        {
            //if(string.IsNullOrEmpty(product.Name))
            //{
            //    ModelState.AddModelError("Name", "Name Is Reqierd");
            //}
            //if (string.IsNullOrEmpty(product.Description))
            //{
            //    ModelState.AddModelError("Description", "Description Is Reqierd");
            //}
            //if (product.Price < 1)
            //{
            //    ModelState.AddModelError("Price", "Price Should be grater than 0");
            //}
            //if (product.CategoryId < 1)
            //{
            //    ModelState.AddModelError("CategoryId", "CategoryId Should be grater than 0");
            //}
            if(ModelState.IsValid)
                return RedirectToAction("Index");

            ModelState.AddModelError("", "Etelaat Ersali Shoma Moshkel Darad");
            return View(product);
        }

        public bool IsVali(string Name)
        {
            return Name == "Valid";
        }
    }
}

using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestApis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestApis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductApiDbContext _productApiDbContext;

        public ProductController(ProductApiDbContext productApiDbContext)
        {
            _productApiDbContext = productApiDbContext;
        }
        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            var products =  _productApiDbContext.Products.Include(c=>c.Category).Include(c=>c.Supplier).ToList();
            return products;
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var product = await _productApiDbContext.Products.FindAsync(id);
            if (product == null)
                return NotFound();

            return Ok(product);
        }

        [HttpGet("1")]
        public IActionResult GetOne(int id)
        {
            return Redirect("/api/product/3");
        }

        // POST api/<ProductController>
        [HttpPost]
        public IActionResult Post(ProductForSave productForSave)
        {
            _productApiDbContext.Products.Add(productForSave.ToProduct());
            _productApiDbContext.SaveChanges();
            return Ok();
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }


        [HttpPatch("{id}")]
        public async Task<Supplier> PatchSupplier(long id,JsonPatchDocument<Supplier> patchDoc)
        {
            Supplier s = await _productApiDbContext.Suppliers.FindAsync(id);
            if (s != null)
            {
                patchDoc.ApplyTo(s);
                await _productApiDbContext.SaveChangesAsync();
            }
            return s;
        }

    }
}

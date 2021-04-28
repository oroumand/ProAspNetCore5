using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestApis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypesController : ControllerBase
    {
        private readonly ProductApiDbContext _productApiDbContext;

        public TypesController(ProductApiDbContext productApiDbContext)
        {
            _productApiDbContext = productApiDbContext;
        }
        [HttpGet("text")]
        public string GetString()
        {
            return "متن تستی";
        }

        [HttpGet("int")]
        public int GetInt()
        {
            return 100;
        }

        [HttpGet("{id}")]
        [Produces("applicatoin/json")]
        public async Task<IActionResult> Get(int id)
        {
            var product = await _productApiDbContext.Products.FindAsync(id);
            if (product == null)
                return NotFound();

            return Ok(product);
        }


        [HttpGet("object/{format?}")]
        [FormatFilter]
        [Produces("application/json", "application/xml")]
        public async Task<ProductForSave> GetObject()
        {
            Product p = await _productApiDbContext.Products.FirstAsync();
            return new ProductForSave()
            {
                Name = p.Name,
                Price = p.Price,
                CategoryId = p.CategoryId,
                SupplierId = p.SupplierId
            };
        }


        [HttpPost]
        [Consumes("application/json")]
        public IActionResult PostJson(ProductForSave productForSave)
        {
            _productApiDbContext.Products.Add(productForSave.ToProduct());
            _productApiDbContext.SaveChanges();
            return Ok();
        }
        
        //[HttpPost]
        //[Consumes("application/xml")]
        //public IActionResult PostXml(ProductForSave productForSave)
        //{
        //    _productApiDbContext.Products.Add(productForSave.ToProduct());
        //    _productApiDbContext.SaveChanges();
        //    return Ok();
        //}
    }
}

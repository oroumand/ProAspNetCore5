using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Session16.ReceipeApp.Shared;
namespace Session16.ReceipeApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceipesController : ControllerBase
    {
        public IActionResult Post(Receipe receipe)
        {
            return Ok();
        }
    }
}

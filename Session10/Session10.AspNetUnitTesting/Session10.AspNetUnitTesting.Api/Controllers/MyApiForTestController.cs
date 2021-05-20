using Microsoft.AspNetCore.Mvc;
using Session10.AspNetUnitTesting.Api.Models;

namespace Session10.AspNetUnitTesting.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyApiForTestController : ControllerBase
    {

        [HttpPost]
        public ActionResult<string> Post([FromBody] TestInputModel testInputModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            string result = $"{testInputModel.FirstName}-{testInputModel.LastName}";
            return result;
        }


    }
}

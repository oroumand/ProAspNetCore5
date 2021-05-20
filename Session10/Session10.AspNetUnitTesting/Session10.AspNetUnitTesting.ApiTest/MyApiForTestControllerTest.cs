using Microsoft.AspNetCore.Mvc;
using Session10.AspNetUnitTesting.Api.Controllers;
using Session10.AspNetUnitTesting.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Session10.AspNetUnitTesting.ApiTest
{
    public class MyApiForTestControllerTest
    {
        [Fact]
        public void MyApiForTestController_ReturnsFullName()
        {
            var controller = new MyApiForTestController();
            var model = new TestInputModel
            {
                FirstName = "Alireza",
                LastName = "Oroumand"
            };
            ActionResult<string> result = controller.Post(model);
            Assert.NotNull(result);
        }

        [Fact]
        public void MyApiForTestController_ReturnsBadRequestWhenInvalid()
        {
            var controller = new MyApiForTestController();
            var model = new TestInputModel
            {
                FirstName = "",
                LastName = ""
            };
            controller.ModelState.AddModelError(nameof(model.FirstName), "FirstName Required");
            controller.ModelState.AddModelError(nameof(model.LastName), "LastName Required");
            ActionResult<string> result = controller.Post(model);
            Assert.IsType<BadRequestObjectResult>(result.Result);
        }
    }
}

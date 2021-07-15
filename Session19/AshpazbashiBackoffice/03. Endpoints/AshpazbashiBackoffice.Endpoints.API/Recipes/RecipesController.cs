using AshpazbashiBackoffice.Core.ApplicationServices.Recipes.Commands.Add;
using AshpazbashiBackoffice.Core.ApplicationServices.Recipes.Commands.Delete;
using AshpazbashiBackoffice.Core.ApplicationServices.Recipes.Commands.Edit;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AshpazbashiBackoffice.Endpoints.API.Recipes
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        private readonly IMediator mediator;

        public RecipesController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> Post(AddRecipeCommand addRecipeCommand)
        {
            var result = await mediator.Send(addRecipeCommand);
            return StatusCode(201, result);
        }

        [HttpPut]
        public async Task<IActionResult> Put(EditRecipeCommand editRecipeCommand)
        {
            var result = await mediator.Send(editRecipeCommand);
            return Ok(result);
        }


        [HttpDelete]
        public async Task<IActionResult> Delete(DeleteRecipeCommand deleteRecipeCommand)
        {
            var result = await mediator.Send(deleteRecipeCommand);
            return StatusCode(204, result);
        }
    }
}

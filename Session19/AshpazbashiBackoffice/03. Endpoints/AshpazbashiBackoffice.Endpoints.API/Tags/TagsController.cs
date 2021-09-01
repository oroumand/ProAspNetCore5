using AshpazbashiBackoffice.Core.ApplicationServices.Tags.Commands.Add;
using AshpazbashiBackoffice.Core.ApplicationServices.Tags.Commands.Delete;
using AshpazbashiBackoffice.Core.ApplicationServices.Tags.Commands.Edit;
using AshpazbashiBackoffice.Core.ApplicationServices.Tags.Queries.Find;
using AshpazbashiBackoffice.Core.ApplicationServices.Tags.Queries.GetTagList;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AshpazbashiBackoffice.Endpoints.API.Tags
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController : ControllerBase
    {
        private readonly IMediator mediator;

        public TagsController(IMediator mediator)
        {
            this.mediator = mediator;
        }


        [HttpPost]
        public async Task<IActionResult> Post(AddTagCommand addTagCommand)
        {
            var result = await mediator.Send(addTagCommand);
            return StatusCode(201, result);
        }

        [HttpPut]
        public async Task<IActionResult> Put(EditTagCommand editTagCommand)
        {
            var result = await mediator.Send(editTagCommand);
            return Ok(result);
        }


        [HttpDelete]
        public async Task<IActionResult> Delete(DeleteTagCommand deleteTagCommand)
        {
            var result = await mediator.Send(deleteTagCommand);
            return StatusCode(204, result);
        }
        [HttpGet("/find")]
        public async Task<ActionResult> Find([FromQuery]FindTagQuery findTagQuery)
        {
            var result = await mediator.Send(findTagQuery);
            return Ok(result);
        }

        [HttpGet("search")]
        public async Task<ActionResult> Search()
        {
            var result = await mediator.Send(new GetTagListQuery());
            return Ok(result);
        }
    }
}

using MediatR;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Sqrs.Commads.CreatStore.CQRS.Commands.CreateStore;
using Sqrs.Queries.GetStoreById;

namespace Sqrs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoreController(ISender sender) : ControllerBase
    {
        private readonly ISender _sender = sender;

        [HttpPost]
        public async Task<IActionResult> Add([FromForm] CreateStoreCommand command)
        {
            await _sender.Send(command);
            return Ok();
        }


        [HttpGet]
        public async Task<ActionResult<StoreResponse>> Get(long id)
        {

            var data = await _sender.Send(new GetStoreByIdQuery(id));
            return Ok(data);
        }
    }
}

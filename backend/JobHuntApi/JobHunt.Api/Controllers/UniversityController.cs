using JobHunt.Application.Command.University.CreateUniversity;
using JobHunt.Application.Command.University.DeleteUniversity;
using JobHunt.Application.Command.University.UpdateUniversity;
using JobHunt.Application.Request.University;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using IMediator = MassTransit.Mediator.IMediator;

namespace JobHuntApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Employee")]
    public class UniversityController : ControllerBase
    {
        private readonly ISender _sender;

        public UniversityController(ISender sender)
        {
            _sender = sender;
        }
        

        [HttpPost("create")]
        
        public async Task<ActionResult> CreateUniversity( [FromQuery] Guid profileId, [FromBody] CreateUniversityRequest request)
        {
            var result = await _sender.Send(new CreateUniversityCommand(request, profileId));
            
            return Ok(result);
        }

        [HttpPut("update/{id}")]

        public async Task<ActionResult> UpdateUniversity([FromBody] UpdateUniversityRequest request, [FromRoute] Guid id)
        {
            var result = await _sender.Send(new UpdateUniversityCommand( id,request));
            
            return Ok(result);
        }

        [HttpDelete("delete/{id}")]

        public async Task<ActionResult> DeleteUniversity([FromRoute] Guid id)
        {

            var result = await _sender.Send(new DeleteUniversityCommand(id));
            
            return Ok(result);
        }
    }
}


using JobHunt.Application.Command.Experience.CreateExperience;
using JobHunt.Application.Command.Experience.DeleteExperience;
using JobHunt.Application.Command.Experience.UpdateExperience;
using JobHunt.Application.Request.Experience;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace JobHuntApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Employee")]
    public class ExperienceController : ControllerBase
    {
        private readonly ISender _sender;

        public ExperienceController(ISender sender)
        {
            _sender = sender;
        }

        [HttpPost("create")]
        
        public async Task<ActionResult> CreateExperience([FromQuery] Guid profileId,[FromBody] CreateExperienceRequest request)
        {
            var result = await _sender.Send(new CreateExperienceCommand(request, profileId));
            
            return Ok(result);
        }
        
        

        [HttpPut("update/{id}")]
        
        public async Task<ActionResult> UpdateExperience(Guid id, [FromBody] UpdateExperienceRequest request)
        {
            var result = await _sender.Send(new UpdateExperienceCommand(id, request));
            
            return Ok(result);
        }

        [HttpDelete("delete/{id}")]
        
        public async Task<ActionResult> DeleteExperience(Guid id)
        {
            var result =  await _sender.Send(new DeleteExperienceCommand(id));
            
            return Ok(result);
        }
    }
}

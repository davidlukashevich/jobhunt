using JobHunt.Application.Command.Job.CreateJob;
using JobHunt.Application.Command.Job.DeleteJob;
using JobHunt.Application.Command.Job.UpdateJob;
using JobHunt.Application.Query.Job.GetAllJobs;
using JobHunt.Application.Query.Job.GetAllJobsByCreatedById;
using JobHunt.Application.Query.Job.GetAllJobsByFilter;
using JobHunt.Application.Query.Job.GetAllJobsByTitle;
using JobHunt.Application.Query.Job.GetJobById;
using JobHunt.Application.Request;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JobHuntApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        
        private readonly ISender _sender;

        public JobController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet("")]

        public async Task<ActionResult> GetAllJobs()
        {
            var result = await _sender.Send(new GetAllJobsQuery());
            
            return Ok(result);
        }
        
        [HttpGet("byFilter")]

        public async Task<ActionResult> GetAllJobsByFilter([FromQuery] string? type, [FromQuery] string? technology, [FromQuery] string? level )
        {
            var result = await _sender.Send(new GetAllJobsByFilterQuery(type, technology, level));
            
            return Ok(result);
        }

        [HttpGet("createdBy/{id}")]
        [Authorize(Roles = "Employer")]

        public async Task<ActionResult> GetAllJobsByCreatedById([FromRoute] string id)
        {
            var result = await _sender.Send(new GetAllJobsByCreatedByIdQuery(id));
            
            return Ok(result);
        }
        
        [HttpGet("{id}")]

        public async Task<ActionResult> GetJobById([FromRoute] Guid id)
        {
            var result = await _sender.Send(new GetJobByIdQuery(id));
            
            return Ok(result) ;
        }

        [HttpGet("byTitle")]

        public async Task<ActionResult> GetAllJobsByTitle([FromQuery] string title)
        {

            var result = await _sender.Send(new GetAllJobsByTitleQuery(title));

            return Ok(result);
        }

        [HttpPost("create")]
        [Authorize(Roles = "Employer")]
        public async Task<ActionResult> CreateJob([FromForm] CreateJobRequest createJobRequest)
        {
            
            var result = await _sender.Send(new CreateJobCommand(createJobRequest));
            
            return Ok(result);
        }


        [HttpPut("update/{id}")]
        [Authorize(Roles = "Employer")]
        public async Task<ActionResult> UpdateJob(Guid id, [FromBody] UpdateJobRequest updateJobRequest)
        {
            var result = await _sender.Send(new UpdateJobByIdCommand(id, updateJobRequest));
            
            return Ok(result);
        }

        [HttpDelete("delete/{id}")]
        [Authorize(Roles = "Employer")]
        public async Task<ActionResult> DeleteJob(Guid id, [FromQuery] Guid addressId, [FromQuery] Guid imageId)
        {
            var result = await _sender.Send(new DeleteJobByIdCommand(id, addressId, imageId));
            
            return Ok(result);
        }
    }
}

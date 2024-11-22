using JobHunt.Application.Command.JobApplication.CreateJobApplication;
using JobHunt.Application.Command.JobApplication.UpdateJobApplicationStatus;
using JobHunt.Application.Query.JobApplication.GetAllJobApplicationsByCreatedById;
using JobHunt.Application.Query.JobApplication.GetJobApplicationById;
using JobHunt.Application.Query.JobApplication.GetJobApplicationsByJobId;
using JobHunt.Application.Request.JobApplication;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace JobHuntApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobApplicationController : ControllerBase
    {
   
        private readonly ISender _sender;
        
        public JobApplicationController(ISender sender)
        {
            _sender = sender;
        }
        
        [HttpPost("create")]
        [Authorize(Roles = "Employee, Employer")]
        
        
        public async Task<ActionResult> CreateJobApplication([FromForm] CreateJobApplicationRequest request)
        {
            var result = await _sender.Send(new CreateJobApplicationCommand(request));
            
            return Ok(result);
        }

        [HttpGet("application/{id}")]
        [Authorize(Roles = "Employer")]
        
        public async Task<ActionResult> GetJobApplicationById([FromRoute] Guid id)
        {
            var result = await _sender.Send(new GetJobApplicationByIdQuery(id));
            
            return Ok(result);
        }

        [HttpGet("job/{id}")]
        [Authorize(Roles = "Employer")]
        
        public async Task<ActionResult> GetJobApplicationsByJobId([FromRoute] Guid id)
        {
            var result = await _sender.Send(new GetJobApplicationsByJobIdQuery(id));
            
            return Ok(result);
        }
        
        [HttpGet("createdBy/{id}")]
        [Authorize(Roles = "Employee")]
        
        public async Task<ActionResult> GetJobApplicationsByCreatedById([FromRoute] string id)
        {
            var result = await _sender.Send(new GetAllJobApplicationsByCreatedByIdQuery(id));
            
            return Ok(result);
        }

        [HttpPut("update/application/{id}")]
        [Authorize(Roles = "Employer")]
        public async Task<ActionResult> ChangeJobApplicationStatus([FromRoute] Guid id,
            [FromBody] UpdateJobApplicationStatusRequest request)
        {
            var result = await _sender.Send(new UpdateJobApplicationStatusCommand(id, request.Status));
            
            return Ok(result);
        }

    }
}

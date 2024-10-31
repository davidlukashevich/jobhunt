using JobHunt.Application.Command.JobApplication.CreateJobApplication;
using JobHunt.Application.Query.JobApplication.GetJobApplicationById;
using JobHunt.Application.Query.JobApplication.GetJobApplicationsByJobId;
using JobHunt.Application.Request;
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
    }
}

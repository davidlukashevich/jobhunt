using JobHunt.Application.Command.Profile.CreateProfile;
using JobHunt.Application.Command.Profile.UpdateProfile;

using JobHunt.Application.Query.Profile.GetProfile;
using JobHunt.Application.Request.Profile;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JobHuntApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Employee, Employer")]
    public class ProfileController : ControllerBase
    {
        private readonly ISender _sender;

        public ProfileController(ISender sender)
        {
            _sender = sender;
        }

        [HttpPost("create")]
        public async Task<ActionResult> CreateProfile([FromForm] CreateProfileRequest request)
        {
            var result = await _sender.Send(new CreateProfileCommand(
                   request
                ));
            
            return Ok(result);
        }
        
        

        [HttpPut("update/{id}")]

        public async Task<ActionResult> UpdateProfile([FromForm] UpdateProfileRequest updateProfileRequest, [FromRoute] Guid id)
        {
            var result = await _sender.Send(new UpdateProfileCommand(updateProfileRequest, id));
            
            return Ok(result);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult> GetProfile([FromRoute] string id)
        {
            var result = await _sender.Send(new GetProfileQuery(id));
            
            return Ok(result);
        }
    }
}

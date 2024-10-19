using JobHunt.Application.Command.Profile.CreateProfile;
using JobHunt.Application.Command.Profile.UpdateProfile;
using JobHunt.Application.Query.Profile.GetProfile;
using JobHunt.Application.Request;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace JobHuntApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly ISender _sender;

        public ProfileController(ISender sender)
        {
            _sender = sender;
        }

        [HttpPost("create")]

        public async Task<ActionResult> CreateProfile([FromBody] CreateProfileRequest createProfileRequest)
        {
            var result = await _sender.Send(new CreateProfileCommand(createProfileRequest));
            
            return Ok(result);
        }

        [HttpPut("update/{id}")]

        public async Task<ActionResult> UpdateProfile([FromBody] UpdateProfileRequest updateProfileRequest, [FromRoute] Guid id)
        {
            var result = await _sender.Send(new UpdateProfileCommand(updateProfileRequest, id));
            
            return Ok(result);
        }

        [HttpGet("/{id}")]

        public async Task<ActionResult> GetProfile([FromRoute] Guid id)
        {
            var result = await _sender.Send(new GetProfileQuery(id));
            
            return Ok(result);
        }
    }
}

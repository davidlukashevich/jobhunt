using JobHunt.Application.Command.User.UserChangePassword;
using JobHunt.Application.Command.User.UserLogin;
using JobHunt.Application.Command.User.UserRegister;
using JobHunt.Application.Command.User.UserSignOut;
using JobHunt.Application.Request.User;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JobHuntApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ISender _sender;
        

        public UserController(ISender sender)
        {
            _sender = sender;
            
        }


        [HttpPost("login")]

        public async Task<ActionResult> UserLogin([FromBody] UserLoginRequest request)
        {
            var result = await _sender.Send(new UserLoginCommand(request));
            
            return Ok(result);
        }

        [HttpPost("register")]

        public async Task<ActionResult> UserRegister([FromBody] UserRegisterRequest request)
        {
            var result = await _sender.Send(new UserRegisterCommand(request));
            
            return Ok(result);
        }

        [HttpPost("changePassword")]
        [Authorize(Roles = "Employer, Employee")]
        public async Task<ActionResult> UserChangePassword([FromBody] ChangeUserPasswordRequest request)
        {
            var result = await _sender.Send(new UserChangePasswordCommand(request));
            
            return Ok(result);
        }

        [HttpDelete("logout")]
        [Authorize(Roles = "Employer, Employee")]

        public async Task<ActionResult> UserLogout()
        {
            var result = await _sender.Send(new UserSignOutCommand());
            
            return Ok(result);
        }
    }
}

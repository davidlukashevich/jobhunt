using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobHuntApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]

        public async Task<ActionResult> Get()
        {
            return Ok("Hello World!");
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace UserIdentityAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private static readonly string[] Users = new[]
        {
            "Kumudini", "Trupti", "Kishor", "Yogesh"
        };     

        [HttpGet]
        [Route("GetAllUsers")]
        public async Task<IActionResult> Get()
        {
            await Task.Delay(4000); //4sec delay
            return Ok(new { UserListing = Users });
        }
    }
}

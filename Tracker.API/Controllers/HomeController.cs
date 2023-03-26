using Microsoft.AspNetCore.Mvc;

namespace Tracker.API.Controllers;

[ApiController]
[Route("home")]
[Produces("application/json")]
public class HomeController : ControllerBase
{
    [HttpGet("name")]
    public ActionResult GetName()
    {
        return Ok("Shahzad");
    }
    
    [HttpGet("age")]
    public ActionResult GetAge()
    {
        return Ok(18);
    }
}
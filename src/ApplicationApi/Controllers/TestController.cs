using Microsoft.AspNetCore.Mvc;

namespace ApplicationApi.Controllers  // Adjust the namespace appropriately
{
    [ApiController] // This attribute designates this class as a controller for an API.
    [Route("[controller]")] // This sets the route template, which the controller responds to.
    public class TestController : ControllerBase // For APIs, ControllerBase is more common because it doesn't include view support.
    {
        [HttpGet] // Specifies that this action only responds to HTTP GET requests.
        public IActionResult Index()
        {
            return Ok("Test result");
        }
    }
}
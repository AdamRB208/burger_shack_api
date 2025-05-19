namespace burger_shack_api.Controllers;

[ApiController]
[Route("api/burgers")]
public class BurgersController : ControllerBase
{
  [HttpGet("test")]
  public string Test()
  {
    return "Burgers Controller is running";
  }
}
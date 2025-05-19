namespace burger_shack_api.Controllers;

[ApiController]
[Route("api/burgers")]
public class BurgersController : ControllerBase
{

  public BurgersController(BurgersService burgersService)
  {
    _burgersService = burgersService;
  }

  private readonly BurgersService _burgersService;

  [HttpGet("test")]
  public string Test()
  {
    return "Burgers Controller is running";
  }

  [HttpGet]
  public ActionResult<List<Burger>> GetAllBurgers()
  {
    try
    {
      List<Burger> burgers = _burgersService.GetAllBurgers();
      return Ok(burgers);
    }
    catch (Exception error)
    {
      return BadRequest(error.Message);
    }
  }

  [HttpGet("{burgerId}")]
  public ActionResult<Burger> GetBurgerById(string burgerId)
  {
    try
    {
      Burger burger = _burgersService.GetBurgerById(burgerId);
      return Ok(burger);
    }
    catch (Exception error)
    {
      return BadRequest(error.Message);
    }
  }
}

namespace burger_shack_api.Services;

public class BurgersService
{

  public BurgersService(BurgersRepository burgersRepository)
  {
    _burgersRepository = burgersRepository;
  }

  private readonly BurgersRepository _burgersRepository;

  public List<Burger> GetAllBurgers()
  {
    List<Burger> burgers = _burgersRepository.GetAllBurgers();
    return burgers;
  }

  public Burger GetBurgerById(int burgerId)
  {
    Burger burger = _burgersRepository.GetBurgersById(burgerId);
    if (burger == null) throw new Exception($"No burger with the id of {burgerId}.");
    return burger;
  }
}
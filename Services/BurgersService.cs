
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

  public Burger CreateBurger(Burger burgerData)
  {
    Burger burger = _burgersRepository.CreateBurger(burgerData);
    return burger;
  }

  public string DeleteBurger(int burgerId)
  {
    Burger burger = GetBurgerById(burgerId);
    _burgersRepository.DeleteBurger(burgerId);
    return $"{burger.Name} was deleted!";
  }

  public Burger UpdateBurger(int burgerId, Burger burgerData)
  {
    Burger burger = _burgersRepository.UpdateBurger(burgerId, burgerData);
    return burger;
  }
}
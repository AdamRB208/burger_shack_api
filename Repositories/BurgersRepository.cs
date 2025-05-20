

namespace burger_shack_api.Repositories;

public class BurgersRepository
{
  public BurgersRepository(IDbConnection db)
  {
    _db = db;
  }

  private readonly IDbConnection _db;


  public List<Burger> GetAllBurgers()
  {
    string sql = "SELECT * FROM burgers;";
    List<Burger> burgers = _db.Query<Burger>(sql).ToList();
    return burgers;
  }

  public Burger GetBurgersById(int burgerId)
  {
    string sql = "SELECT * FROM burgers WHERE id = @burgerId;";
    Burger burger = _db.Query<Burger>(sql, new { burgerId = burgerId }).SingleOrDefault();
    return burger;
  }

  internal Burger CreateBurger(Burger burgerData)
  {
    string sql = @"INSERT INTO
                  burgers (name, price)
                  VALUES (@Name, @Price);
                  
                  SELECT * FROM burgers WHERE id = LAST_INSERT_ID();";

    Burger burger = _db.Query<Burger>(sql, burgerData).SingleOrDefault();
    return burger;
  }
}
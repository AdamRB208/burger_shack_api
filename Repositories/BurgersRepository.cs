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
}
using System.Data;

namespace Keepr.Repositories
{
  public class NotesRepository
  {
    private readonly IDbConnection _db;
    public NotesRepository(IDbConnection db)
    {
      _db = db;
    }
  }
}
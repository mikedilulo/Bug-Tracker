using Keepr.Repositories;

namespace Keepr.Services
{
  public class NotesService
  {
    private readonly NotesRepository _noterepo;
    public NotesService(NotesRepository noterepo)
    {
      _noterepo = noterepo;
    }
  }
}
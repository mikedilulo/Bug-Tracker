using Keepr.Services;
using Microsoft.AspNetCore.Mvc;

namespace Keepr.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class NotesController : ControllerBase
  {
    private readonly NotesService _ns;
    public NotesController(NotesService ns)
    {
      _ns = ns;
    }
  }
}
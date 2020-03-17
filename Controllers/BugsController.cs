using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Keepr.Models;
using Keepr.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Keepr.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class BugsController : ControllerBase
  {
    private readonly BugsService _bs;
    public BugsController(BugsService bs)
    {
      _bs = bs;
    }
    [HttpGet]
    [Authorize]
    public ActionResult<IEnumerable<Bug>> GetAllBugs(string userId)
    {
      try
      {
        var creatorId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        return Ok(_bs.GetAllBugs(userId));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}
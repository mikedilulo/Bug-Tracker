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
    public ActionResult<IEnumerable<Bug>> GetAllBugs()
    {
      try
      {
        return Ok(_bs.GetAllBugs());
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet("{id}")]
    [Authorize]
    public ActionResult<Bug> GetBugById(int id)
    {
      try
      {
        return Ok(_bs.GetBugById(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPost]
    [Authorize]
    public ActionResult<Bug> Create([FromBody] Bug newBugData)
    {
      try
      {
        var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        newBugData.UserId = userId;
        return Ok(_bs.CreateNewBug(newBugData));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}
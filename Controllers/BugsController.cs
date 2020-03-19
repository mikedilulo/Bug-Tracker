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
    private readonly NotesService _ns;
    public BugsController(BugsService bs, NotesService ns)
    {
      _bs = bs;
      _ns = ns;
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

    [HttpGet("/closed")]
    [Authorize]
    public ActionResult<IEnumerable<Bug>> GetAllClosedBugs()
    {
      try
      {
        return Ok(_bs.GetAllClosedBugs());
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet("{id}/notes")]
    [Authorize]
    public ActionResult<IEnumerable<Note>> GetNotesByBugId(int id)
    {
      try
      {
        return Ok(_ns.GetNotesByBugId(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet("{id}")]
    [Authorize]
    public ActionResult<Bug> GetById(int id)
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

    [HttpPut("{id}")]
    [Authorize]
    public ActionResult<Bug> Edit([FromBody] Bug editedBug, int id)
    {
      try
      {
        editedBug.Id = id;
        editedBug.UserId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        return Ok(_bs.EditBugById(editedBug));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    //WILL CREATE DELETE METHOD MORE FOR TESTING PURPOSES. DELETES WILL BE "SOFT"
    [HttpDelete("{id}")]
    [Authorize]
    public ActionResult<string> Delete(int id)
    {
      try
      {
        return Ok(_bs.DeleteBugById(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}
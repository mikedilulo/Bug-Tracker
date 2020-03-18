using System;
using System.Collections.Generic;
using System.Data;
using Keepr.Models;

namespace Keepr.Repositories
{
  public class NotesRepository
  {
    private readonly IDbConnection _db;
    public NotesRepository(IDbConnection db)
    {
      _db = db;
    }

    internal IEnumerable<Note> GetNotesByBugId(int bugId)
    {
      throw new NotImplementedException();
    }
  }
}
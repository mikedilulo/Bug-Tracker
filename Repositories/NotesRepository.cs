using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
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
      string sql = "SELECT * FROM notes WHERE bugId = @bugId";
      return _db.Query<Note>(sql, new { bugId });
    }

    internal object GetNoteById(int id)
    {
      throw new NotImplementedException();
    }

    internal int CreateNewNote(Note newNoteData)
    {
      throw new NotImplementedException();
    }

    internal void EditNoteById(int id)
    {
      throw new NotImplementedException();
    }

    internal void DeleteNoteById(int id)
    {
      throw new NotImplementedException();
    }
  }
}
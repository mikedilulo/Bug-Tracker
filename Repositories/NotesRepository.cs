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

    internal Note GetNoteById(int id)
    {
      string sql = "SELECT * FROM notes WHERE id = @id";
      return _db.QueryFirstOrDefault<Note>(sql, new { id });
    }

    internal int CreateNewNote(Note newNoteData)
    {
      string sql = @"
      INSERT INTO notes
      (userId, title, description, noteCreatedBy, timeCreated)
      VALUES
      (@UserId, @Title, @Description, @NoteCreatedBy, @TimeCreated)
      SELECT LAST_INSERT_ID();
      ";
      int id = _db.ExecuteScalar<int>(sql, newNoteData);
      newNoteData.Id = id;
      return id;
    }

    internal void EditNoteById(int id)
    {
      string sql = @"
      UPDATE notes
      SET
      userId = @UserId,
      title = @Title,
      description = @Description,
      noteCreatedBy = @NoteCreatedBy,
      timeEdited = @TimeEdited
      (WHERE id = @id)";
      _db.Execute(sql, new { id });
    }

    internal void DeleteNoteById(int id)
    {
      string sql = "DELETE FROM notes WHERE id = @id";
      _db.Execute(sql, new { id });
    }
  }
}
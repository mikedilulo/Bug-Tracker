using System;
using System.Collections.Generic;
using Keepr.Models;
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

    internal IEnumerable<Note> GetNotesByBugId(int bugId)
    {
      return _noterepo.GetNotesByBugId(bugId);
    }

    internal Note GetNoteById(int id)
    {
      var foundNote = _noterepo.GetNoteById(id);
      if (foundNote == null) { throw new Exception("Invalid: Note Cannot Be Found"); }
      return foundNote;
    }

    internal Note CreateNewNote(Note newNoteData)
    {
      newNoteData.Id = _noterepo.CreateNewNote(newNoteData);
      return newNoteData;
    }

    internal Note EditNoteById(int id)
    {
      throw new NotImplementedException();
    }

    internal object DeleteNoteById(int id)
    {
      throw new NotImplementedException();
    }
  }
}
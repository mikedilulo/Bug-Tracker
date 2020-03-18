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

    internal object GetNoteById(int id)
    {
      throw new NotImplementedException();
    }

    internal object CreateNewNote(Note newNoteData)
    {
      throw new NotImplementedException();
    }
  }
}
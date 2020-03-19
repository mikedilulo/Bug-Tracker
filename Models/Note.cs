using System;

namespace Keepr.Models
{
  public class Note
  {
    public int Id { get; set; }
    public string UserId { get; set; }
    public int BugId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string NoteCreatedBy { get; set; }
    public string NoteEditedBy { get; set; }
    public DateTime NoteTimeCreated { get; set; }
    public DateTime NoteTimeEdited { get; set; }
  }
}
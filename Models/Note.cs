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
    public DateTime TimeCreated { get; set; }
    public DateTime TimeEdited { get; set; }
  }
}
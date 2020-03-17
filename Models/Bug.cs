using System;

namespace Keepr.Models
{
  public class Bug
  {
    public int Id { get; set; }
    public string UserId { get; set; }
    public string Title { get; set; }
    public string Subject { get; set; }
    public string Description { get; set; }
    public string ReportedBy { get; set; }
    public bool IsClosed { get; set; }
    public DateTime LastModified { get; set; }
    public DateTime BugCreated { get; set; }
    public DateTime BugClosed { get; set; }
    public DateTime DaysOpen { get; set; }

  }
}
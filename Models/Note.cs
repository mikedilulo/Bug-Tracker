namespace Keepr.Models
{
  public class Note
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string NoteCreatedBy { get; set; }
  }
}
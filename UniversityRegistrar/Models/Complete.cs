using System.Collections.Generic;

namespace University.Models
{
  public class Complete
  {
    public int CompleteId { get; set; }
    public int StudentId { get; set; }
    public int CourseId { get; set; }
    public virtual Student Student { get; set; }
    public virtual Course Course { get; set; }
  }
}
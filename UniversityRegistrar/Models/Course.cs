using System;
using System.Collections.Generic;

namespace University.Models
{
  public class Course
  {
    public Course()
    {
    this.JoinEntities = new HashSet<Enrollments>();
    }
    
    public int CourseId { get; set; }
    public string Name { get; set; }
    public string Number { get; set; }
    public virtual ICollection<Enrollments> JoinEntities { get; }
    public virtual ICollection<Complete> CompleteEntities { get; }
  }
}
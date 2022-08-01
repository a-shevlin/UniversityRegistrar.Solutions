using System;
using System.Collections.Generic;

namespace University.Models
{
  public class Student
  {
    public Student()
    {
    this.JoinEntities = new HashSet<Enrollments>();
    }
    
    public int StudentId { get; set; }
    public string Name { get; set; }
    public DateTime EnrollmentDate { get; set; }
    public virtual ICollection<Enrollments> JoinEntities { get; }
  }
}
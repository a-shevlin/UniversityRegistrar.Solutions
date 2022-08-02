using System;
using System.Collections.Generic;

namespace University.Models
{
  public class Major
  {
    public Major()
    {
      this.JoinDepartments = new HashSet<Departments>();
    }

    public int MajorId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Departments> JoinDepartments { get; }
  }
}
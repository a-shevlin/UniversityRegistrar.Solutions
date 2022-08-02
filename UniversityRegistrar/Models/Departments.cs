using System.Collections.Generic;

namespace University.Models
{
  public class Departments
  {
    public int DepartmentsId { get; set; }
    public string Name { get; set; }
    public int MajorId { get; set; }

    public virtual Major Major { get; set; }
  }
}
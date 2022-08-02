using Microsoft.EntityFrameworkCore;

namespace University.Models
{
  public class UniversityRegistrarContext : DbContext
  {
    public DbSet<Course> Courses { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Enrollments> Enrollments { get; set; }
    public DbSet<Complete> Complete { get; set; }
    public DbSet<Major> Majors { get; set; }
    public DbSet<Departments> Departments { get; set; }

    public UniversityRegistrarContext(DbContextOptions options) : base(options) {}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}
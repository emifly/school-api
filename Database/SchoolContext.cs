using lesson_16_demo_2.Models;
using Microsoft.EntityFrameworkCore;

namespace lesson_16_demo_2.Database;

public class SchoolContext : DbContext
{
    public DbSet<Student> Students { get; set; } = null!;
    public DbSet<Subject> Subjects { get; set; } = null!;
    public DbSet<Grade> Grades { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("school");
    }
}

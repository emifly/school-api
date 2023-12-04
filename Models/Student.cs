namespace lesson_16_demo_2.Models;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public List<Grade> Grades { get; set; } = new();
}

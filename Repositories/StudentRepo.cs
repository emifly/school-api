using lesson_16_demo_2.Database;
using lesson_16_demo_2.Models;

public class StudentRepo
{
    private readonly SchoolContext _context;

    public StudentRepo(SchoolContext context)
    {
        _context = context;
    }

    public List<Student> GetAllStudents()
    {
        return _context.Students.ToList();
    }

    public Student GetStudent(int id)
    {
        return _context.Students.Single(student => student.Id == id);
    }

    public Student CreateStudent(string name)
    {
        var student = _context.Add(new Student
        {
            Name = name,
        });
        _context.SaveChanges();
        return student.Entity;
    }

    public Student ModifyStudent(int id, string newName)
    {
        var student = _context.Students.Single(student => student.Id == id);
        student.Name = newName;
        _context.SaveChanges();
        return student;
    }

    public Student DeleteStudent(int id)
    {
        var student = _context.Students.Single(student => student.Id == id);
        _context.Remove(student);
        _context.SaveChanges();
        return student;
    }
}

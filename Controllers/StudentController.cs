using Microsoft.AspNetCore.Mvc;

namespace lesson_16_demo_2.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StudentController : ControllerBase
{
    private readonly StudentRepo _students;

    public StudentController(StudentRepo students)
    {
        _students = students;
    }

    [HttpGet]
    public IActionResult GetAllStudents()
    {
        return Ok(_students.GetAllStudents());
    }

    [HttpGet("{id}")]
    public IActionResult GetStudent([FromRoute] int id)
    {
        return Ok(_students.GetStudent(id));
    }

    [HttpPost]
    public IActionResult CreateStudent([FromBody] string name)
    {
        var newStudent = _students.CreateStudent(name);
        return CreatedAtAction(nameof(GetStudent), new { id = newStudent.Id }, new { Name = name });
    }

    [HttpPut("{id}")]
    public IActionResult ModifyStudent([FromRoute] int id, [FromBody] string name)
    {
        return Ok(_students.ModifyStudent(id, newName: name));
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteStudent([FromRoute] int id)
    {
        return Ok(_students.DeleteStudent(id));
    }
}

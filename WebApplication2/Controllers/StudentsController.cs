
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentApi.Data;
using StudentApi.Models;
using WebApplication2.Data;
using WebApplication2.Models;

namespace StudentApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentsController : ControllerBase
{
    private readonly StudentContext _context;

    public StudentsController(StudentContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<Student>>> GetStudents()
    {
        var students = await _context.Students.ToListAsync();

        return Ok(students);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Student>> GetStudent(int id)
    {
        var student = await _context.Students.FindAsync(id);

        if (student == null)
        {
            return NotFound(new
            {
                message = "Student not found."
            });
        }

        return Ok(student);
    }

    [HttpPost]
    public async Task<ActionResult<Student>> CreateStudent(
        Student student)
    {
        student.Id = 0;

        _context.Students.Add(student);

        await _context.SaveChangesAsync();

        return CreatedAtAction(
            nameof(GetStudent),
            new { id = student.Id },
            student);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateStudent(
        int id, Student updatedStudent)
    {
        var student = await _context.Students.FindAsync(id);

        if (student == null)
        {
            return NotFound(new
            {
                message = "Student not found."
            });
        }

        student.Name = updatedStudent.Name;
        student.Age = updatedStudent.Age;
        student.Course = updatedStudent.Course;

        await _context.SaveChangesAsync();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteStudent(int id)
    {
        var student = await _context.Students.FindAsync(id);

        if (student == null)
        {
            return NotFound(new
            {
                message = "Student not found."
            });
        }

        _context.Students.Remove(student);

        await _context.SaveChangesAsync();

        return NoContent();
    }
}

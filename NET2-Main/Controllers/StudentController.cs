using Microsoft.AspNetCore.Mvc;
using NET2_Main.Models;
namespace NET2_Main.Controllers;

public class StudentController : Controller
{
  public IActionResult Index()
  {
    List<Student> students = new List<Student>();
    students.Add(new Student() { StudentName = "Nguyen Van A", Age = 20, StudentId = 1 });
    students.Add(new Student() { StudentName = "Nguyen Van A", Age = 20, StudentId = 1 });
    students.Add(new Student() { StudentName = "Nguyen Van A", Age = 20, StudentId = 1 });
    students.Add(new Student() { StudentName = "Nguyen Van A", Age = 20, StudentId = 1 });
    students.Add(new Student() { StudentName = "Nguyen Van A", Age = 20, StudentId = 1 });

    ViewData["students"] = students;
    ViewData["student_count"] = students.Count;
    return View();
  }
  public IActionResult Create(Student student)
  {
    string Message = student.StudentId + " - " + student.StudentName + " - " + student.Age;
    ViewBag.Message = Message;
    return View();
  }
}

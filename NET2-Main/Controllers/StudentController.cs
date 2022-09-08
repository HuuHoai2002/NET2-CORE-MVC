using Microsoft.AspNetCore.Mvc;
using NET2_Main.Models;
namespace NET2_Main.Controllers;

public class StudentController : Controller
{
  public IActionResult Index(string Fullname)
  {
    string Message = "Student " + Fullname + " has been created";
    ViewBag.Message = Message;
    return View();
  }
  public IActionResult Create(Student student)
  {
    string Message = student.StudentId + " - " + student.StudentName + " - " + student.Age;
    ViewBag.Message = Message;
    return View();
  }
}

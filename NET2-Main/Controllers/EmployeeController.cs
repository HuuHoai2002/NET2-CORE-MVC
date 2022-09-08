using Microsoft.AspNetCore.Mvc;
using NET2_Main.Models;

namespace NET2_Main.Controllers;

public class EmployeeController : Controller
{
  public IActionResult Create(Employee emp)
  {
    string Message = emp.EmployeeId + " - " + emp.EmployeeName + " - " + emp.Age;
    ViewBag.Message = Message;
    return View();
  }
}
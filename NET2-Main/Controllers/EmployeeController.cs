using Microsoft.AspNetCore.Mvc;
using NET2_Main.Models;

namespace NET2_Main.Controllers;

public class EmployeeController : Controller
{
  public IActionResult Index()
  {
    List<Employee> emp = new List<Employee>();
    emp.Add(new Employee() { EmployeeName = "Nguyen Van A", Age = 20, EmployeeId = 1 });
    emp.Add(new Employee() { EmployeeName = "Nguyen Van A", Age = 20, EmployeeId = 1 });
    emp.Add(new Employee() { EmployeeName = "Nguyen Van A", Age = 20, EmployeeId = 1 });
    emp.Add(new Employee() { EmployeeName = "Nguyen Van A", Age = 20, EmployeeId = 1 });
    emp.Add(new Employee() { EmployeeName = "Nguyen Van A", Age = 20, EmployeeId = 1 });

    ViewData["emps"] = emp;
    ViewData["emp_count"] = emp.Count;
    return View();
  }
  public IActionResult Create(Employee emp)
  {
    string Message = emp.EmployeeId + " - " + emp.EmployeeName + " - " + emp.Age;
    ViewBag.Message = Message;
    return View();
  }
}
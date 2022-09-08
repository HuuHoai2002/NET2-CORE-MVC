using Microsoft.AspNetCore.Mvc;
using NET2_Main.Models;

namespace NET2_Main.Controllers;

public class PersonController : Controller
{
  public IActionResult Create(Person person)
  {
    string Message = person.PersonId + " - " + person.PersonName + " - " + person.Age;
    ViewBag.Message = Message;
    return View();
  }
}
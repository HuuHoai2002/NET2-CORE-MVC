using Microsoft.AspNetCore.Mvc;
using NET2_Main.Models;

namespace NET2_Main.Controllers;

public class PersonController : Controller
{
  public IActionResult Index()
  {
    List<Person> person = new List<Person>();
    person.Add(new Person() { PersonName = "Nguyen Van A", Age = 20, PersonId = 1 });
    person.Add(new Person() { PersonName = "Nguyen Van A", Age = 20, PersonId = 1 });
    person.Add(new Person() { PersonName = "Nguyen Van A", Age = 20, PersonId = 1 });
    person.Add(new Person() { PersonName = "Nguyen Van A", Age = 20, PersonId = 1 });
    person.Add(new Person() { PersonName = "Nguyen Van A", Age = 20, PersonId = 1 });

    ViewData["persons"] = person;
    ViewData["person_count"] = person.Count;
    return View();
  }
  [HttpGet]
  public IActionResult Create()
  {
    return View();
  }
  [HttpPost]
  public IActionResult Create(Person person)
  {
    string Message = person.PersonId + " - " + person.PersonName + " - " + person.Age;
    ViewBag.Message = Message;
    return View();
  }
}
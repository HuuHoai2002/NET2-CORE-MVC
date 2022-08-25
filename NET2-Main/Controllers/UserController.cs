using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NET2_Main.Models;

namespace NET2_Main.Controllers;

public class UserController : Controller
{
  public IActionResult Index()
  {

    ViewData["name"] = "John Doe";
    return View();
  }
}
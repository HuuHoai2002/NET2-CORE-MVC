using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NET2_Main.Models;

namespace NET2_Main.Controllers;

public class HomeController : Controller
{
  private readonly ILogger<HomeController> _logger;

  public HomeController(ILogger<HomeController> logger)
  {
    _logger = logger;
  }

  public IActionResult Index(string a, string b)
  {
    if (a != null && b != null)
    {
      if (int.Parse(a) != 0)
      {
        ViewBag.results = (-int.Parse(b) / int.Parse(a));
      }
      else if (int.Parse(a) == 0)
      {
        ViewBag.results = "PT vô nghiệm";
      }
      else
      {
        ViewBag.results = "PT vô số nghiệm";
      }
    }

    return View();
  }

  public IActionResult Privacy()
  {
    return View();
  }

  [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
  public IActionResult Error()
  {
    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
  }
}

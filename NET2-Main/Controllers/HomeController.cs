using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NET2_Main.Models;

namespace NET2_Main.Controllers;

public class HomeController : Controller
{
  GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();
  private readonly ILogger<HomeController> _logger;

  public HomeController(ILogger<HomeController> logger)
  {
    _logger = logger;
  }

  public IActionResult Index()
  {
    return View();
  }
  public IActionResult GiaiPhuongTrinh()
  {
    return View();
  }
  [HttpPost]
  public IActionResult GiaiPhuongTrinh(string hsA, string hsB, string hsC)
  {
    string message = gpt.GiaiPTBac2(hsA, hsB, hsC);
    ViewBag.message = message;
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

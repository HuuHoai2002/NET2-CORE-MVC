using Microsoft.AspNetCore.Mvc;
using NET2_Main.Models.Process;

namespace NET2_Main.Controllers;

public class DemoController : Controller
{
  StringProcess stringProcess = new StringProcess();

  [HttpGet]
  public IActionResult XuLyChuoi()
  {
    return View();
  }
  [HttpPost]
  public IActionResult XuLyChuoi(string str)
  {
    ViewBag.ThongTin = stringProcess.CapitalizeOneFirstCharacter(str);
    return View();
  }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;

namespace MeetingApp.Controllers;

public class MeetingController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Apply()
    {
        return View();
    }
    public IActionResult List()
    {
        return View();
    }
}
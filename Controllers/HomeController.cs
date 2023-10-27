using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers;
public class HomeController : Controller
{
    public IActionResult Index()
    {
        var meetingInfo = new MeetingInfo(1, "Location 1",new DateTime(2022, 12, 10),10);
        return View(meetingInfo);
    }
    

    

    

}

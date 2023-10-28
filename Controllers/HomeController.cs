using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers;
public class HomeController : Controller
{
    public IActionResult Index()
    {
        int viewCount = Repository.GetUserInfo().Where(x => x.WillAttend == true).Count();
        var meetingInfo = new MeetingInfo(1, "Location 1",new DateTime(2022, 12, 10),viewCount);
        return View(meetingInfo);
    }
}

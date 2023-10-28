using Microsoft.AspNetCore.Mvc;
using MeetingApp.Models;

namespace MeetingApp.Controllers;

public class MeetingController : Controller
{
    public IActionResult Apply()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Apply(UserInfo userInfo)
    {   
        if(ModelState.IsValid){
            Repository.AddUserInfo(userInfo);
            ViewBag.UserCount = Repository.GetUserInfo().Where(x => x.WillAttend == true).Count();
            return View("Thanks",userInfo);
        }
        else{
            return View(userInfo);
        }
    }
    public IActionResult List()
    {
        return View(Repository.GetUserInfo());
    }

    public IActionResult Details(int id)
    {
        return View(Repository.GetById(id));
    }
}
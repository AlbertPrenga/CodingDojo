using Microsoft.AspNetCore.Mvc;

namespace TimeDisplay.Controllers;

public class Hello : Controller
{   
    [HttpGet("/")]

    public ViewResult Index()
    {  DateTime CurrentTime = DateTime.Now;
            ViewBag.time = CurrentTime.ToString("MMMMM dd, yyyy hh:mm tt");
            return View();
    }

}
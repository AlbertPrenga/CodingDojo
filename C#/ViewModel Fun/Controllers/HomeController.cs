using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModel_Fun.Models;

namespace ViewModel_Fun.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    [HttpGet("")]
    public IActionResult Index()
    {   
        string message = "This is a message that will be displayed with Model method from back-end to front end. This method has the same funcitonality with ViewBag.";
        return View("Index", message);
    }
    [HttpGet("Numbers")]
    public IActionResult Numbers()
    {   
        int [] Myarray =  {1,5,8,6,3,10,0};

        return View(Myarray);
    }
   [HttpGet("Users")]
    public IActionResult Users()
    {   
        List <string> Users = new List<string>();
        Users.Add("Moose Philips");
        Users.Add("Jose");
        Users.Add("Carlo");
        Users.Add("Juan");
        Users.Add("Migel");

        return View(Users);
    }

      [HttpGet("User")]
    public IActionResult User()
    {   
        Human newUser = new Human("Moose","Philips");

        return View(newUser);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}

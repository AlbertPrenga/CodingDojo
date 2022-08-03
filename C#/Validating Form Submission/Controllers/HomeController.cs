using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Validating_Form_Submission.Models;

namespace Validating_Form_Submission.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    
    [HttpGet("")]
    public ViewResult Index()
    {   
        return View("Index");
    }


    [HttpPost("Home/Create")]
    public IActionResult Submit(Validator User)
    {
        if (ModelState.IsValid)
           {
            return RedirectToAction("Succes");
           } 
        return View("index");  
            
    }
    [HttpGet("succes")]
    public ViewResult Succes()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

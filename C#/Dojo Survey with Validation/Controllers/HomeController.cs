using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Dojo_Survey_with_Model.Models;

namespace Dojo_Survey_with_Model.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    // [HttpPost("survey")]
    // public IActionResult Submission(Survey yourSurvey)
    // {
    // // Handle your form submission here
    //     return("index", );
    // }

    
    [HttpGet("")]

    public IActionResult Add()
    {
        return View("Add");
    }
    [HttpPost("Create")] 
     public IActionResult Create(Survey Legend)
    {   
        if (ModelState.IsValid)
        {
        return  RedirectToAction("show",Legend);
        }
        else 
        {
            return  View("add");
        }
 
    }
    [HttpGet("show")]
    public IActionResult show(Survey Legend)
    {
        return View(Legend);
    }

    public IActionResult Pr()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

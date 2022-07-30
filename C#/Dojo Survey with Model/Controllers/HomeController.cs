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

    
    [HttpGet("Add")]

    public IActionResult Add()
    {
        return View("Add");
    }
    [HttpPost("Create")] 
     public IActionResult Create(Survey Legend)
    {   
        return View("show", Legend);
 
    }
    public IActionResult Index()
    {
        return View();
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

using Microsoft.AspNetCore.Mvc;
namespace PortfolioII.Controllers;

public class HelloController : Controller
  
  {
    
    [HttpGet]
    [Route("/")]
    public IActionResult HomePage()
    {
        // Same logic for serving a view applies
        // if we provide the exact view name
      return View("HomePage");
    }

    [HttpGet("projects")]
    public IActionResult Projects()
    {
      return View("Projects");

     
    }
     [HttpGet("Contact")]
      public IActionResult Contact()
      {
        return View("Contact");
      }
     

    

}

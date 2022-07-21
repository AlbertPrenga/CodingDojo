using Microsoft.AspNetCore.Mvc;
namespace HelloController.Controllers;

public class HelloController : Controller
  
  {
    
    [HttpGet]
    [Route("info")]
    public ViewResult Index()
    {
        // Same logic for serving a view applies
        // if we provide the exact view name
        return View();
    }

    

}


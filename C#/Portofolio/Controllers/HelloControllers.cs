using Microsoft.AspNetCore.Mvc;
namespace Portofolio.Controllers;

public class HelloController : Controller

{
    [HttpGet]
    [Route("")]

    public string Index()
    {
        return "This is my index!";
    }

    // for each route this controller is to handle:
    [HttpGet]  // type of request
    [Route("/projects")]  //asociated route string (exclude the leading /)
    public string Projects()
    {
        return "These are my projects";
    }

    [HttpGet]
    [Route("/contact")]
    public string Contact()
    {
        return "This is my Contact";
    }

}
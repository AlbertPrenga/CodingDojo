using Microsoft.AspNetCore.Mvc;

namespace Dojo_Survey.Controllers;

public class Home : Controller

{
    [HttpGet("")]
    
    public ViewResult Index()
    {
        return View();
    }

    [HttpPost("Privacy")]

    public IActionResult Method(string Name, string Location, string FavoriteLanguage, string Comment)
    {
        ViewBag.Name = Name;
        ViewBag.Location = Location;
        ViewBag.FavoriteLanguage = FavoriteLanguage;
        ViewBag.Comment = Comment;

        return View("Privacy");
    }

    [HttpGet("pri")]

    public RedirectToActionResult Drejto()
    {
        return RedirectToAction("Index");
    }

}
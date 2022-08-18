using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Chefs_and_Dishes.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Http;



namespace Chefs_and_Dishes.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private MyContext _context; //pra duhet shtuar kjo
   

    public HomeController(ILogger<HomeController> logger, MyContext context )//edhe kjo Mycontext context )
    {
        _logger = logger;
        _context = context; // duhet shtuar kjo

    }
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    [HttpGet("Chef")]
    public IActionResult Chef()
    {   
        List<Chef> AllChefs = _context.Chefs.Include(c => c.CreatedDishes).ToList();
        ViewBag.AllChefs = AllChefs;
        return View();
    }
    [HttpGet("AddChef")]
    public IActionResult AddChef()
    {
        return View();
    }
    [HttpPost("AddingChef")]
    public IActionResult AddChef(Chef NewChef)
    {
        if(ModelState.IsValid)
        {
            _context.Chefs.Add(NewChef);
            _context.SaveChanges();
            return RedirectToAction("Chef");
        }
        else{
        return View("AddChef");
        }
    }
    [HttpGet("AddDish")]
    public IActionResult AddDish()
    {          
    
    ViewBag.AllChefs = _context.Chefs.Include(c=>c.CreatedDishes).ToList();
        return View();
    }
    [HttpGet("Dish")]
    public IActionResult Dish()
    {
        ViewBag.AllDishes = _context.Dishes.Include(c=>c.Cook).ToList();

        return View();
    }
    [HttpPost("AddingDish")]
           public IActionResult AddDish(Dish marrNgaView, int ChefId)
    {    
        Console.WriteLine("IDDDD eshte : " + marrNgaView.ChefId);
        marrNgaView.ChefId = ChefId;
        if(ModelState.IsValid)
        {
            Chef user = _context.Chefs.First(e => e.ChefId == ChefId);
            user.CreatedDishes.Add(marrNgaView);

            _context.Dishes.Add(marrNgaView);
            _context.SaveChanges();
          return RedirectToAction ("Dish");
        }
        Console.WriteLine("Nuk eshte valid: " );
        ViewBag.AllChefs = _context.Chefs.Include(c => c.CreatedDishes).ToList();
        return View();
    }
    // [HttpPost("AddChef")]

    // public IActionResult AddChef(Chef Shefi)
    // {
    //     if(ModelState.IsValid)
    //     {
    //         _context.Chefs.Add(Shefi);
    //         _context.SaveChanges();
    //         return RedirectToAction("Chef");
    //     }
    //     return View();
    // }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

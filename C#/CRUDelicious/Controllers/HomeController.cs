using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;
using Microsoft.EntityFrameworkCore;


namespace CRUDelicious.Controllers;

public class HomeController : Controller
{
    // private readonly ILogger<HomeController> _logger;

    // public HomeController(ILogger<HomeController> logger)
    // {
    //     _logger = logger;
    // }
    private MyContext _context;
     
    // here we can "inject" our context service into the constructor
    public HomeController(MyContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        ViewBag.marrNgaDb = _context.Monsters.ToList();
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    [HttpGet("Add")]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost("Create")]
    public IActionResult Create(Dish Delicious)
    {
        if(ModelState.IsValid)
        {
            _context.Add(Delicious);
            _context.SaveChanges();
            return RedirectToAction("");
        }
        else
        {
            return View("Add");
        }
    }
    [HttpGet("Show/{Id}")]
    public IActionResult Show(int Id)
    {   
        Dish marrNgaDb= _context.Monsters.FirstOrDefault(e => e.DishId == Id);
        return View(marrNgaDb);
    }
    [HttpGet("Edit/{Id}")]
    public IActionResult Edit(int Id)
    {
       Dish marrNgaDb= _context.Monsters.FirstOrDefault(e => e.DishId == Id);
       return View(marrNgaDb);
    }
    [HttpPost("Edit/Update/{Id}")]
    public IActionResult Update(int Id,Dish marrNgaView)
    {
          Dish marrNgaDb= _context.Monsters.FirstOrDefault(e => e.DishId == Id);
          marrNgaDb.Name = marrNgaView.Name;
          marrNgaDb.Chef = marrNgaView.Chef;
          marrNgaDb.Description = marrNgaView.Description;
          marrNgaDb.Calories = marrNgaView.Calories;
          marrNgaDb.Tastines = marrNgaView.Tastines;
          marrNgaDb.UpdatedAt = DateTime.Now;
          _context.SaveChanges();
          
        return  RedirectToAction("");
    }
    // Inside HomeController
[HttpGet("delete/{Id}")]
public IActionResult Delete(int Id)
    {
        // Like Update, we will need to query for a single user from our Context object
        Dish marrNgaDb = _context.Monsters.SingleOrDefault(user => user.DishId == Id);

        // Then pass the object we queried for to .Remove() on Users
        _context.Monsters.Remove(marrNgaDb);

        // Finally, .SaveChanges() will remove the corresponding row representing this User from DB 
        _context.SaveChanges();
        // Other code
        return RedirectToAction("");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

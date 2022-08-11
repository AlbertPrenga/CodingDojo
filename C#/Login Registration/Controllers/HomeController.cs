using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Login_Registration.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace Login_Registration.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private MyContext _context;

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    [HttpGet("Register")]
      
    public IActionResult Register()
    {   
        HttpContext.Session.GetInt32("UserId");
        if (HttpContext.Session.GetInt32("UserId")== null)
        {
            return View();
        }
        return RedirectToAction("success");
  
    }
    [HttpPost("Register")]
    public IActionResult Register(User Perdoruesi)
    {

        if(ModelState.IsValid)
        {
            // If a User exists with provided email
            if(_context.Users.Any(u => u.Email == Perdoruesi.Email))
            {
                // Manually add a ModelState error to the Email field, with provided
                // error message
                ModelState.AddModelError("Email", "Email already in use!");
                return  View();
                
                // You may consider returning to the View at this point
            }
            PasswordHasher<User> Hasher = new PasswordHasher<User>();
            Perdoruesi.Password = Hasher.HashPassword(Perdoruesi, Perdoruesi.Password);
            _context.Users.Add(Perdoruesi);
            _context.SaveChanges();
            return RedirectToAction("Login");
        }
        return View();
    }    

    [HttpGet("home/Login")]
    public IActionResult Login(int id)
    {
    if (HttpContext.Session.GetInt32("UserId") == null)
     {
        return View();
        
     }
  
   
       return RedirectToAction("success");
       
      
    
    }

    [HttpPost("Login")]
    public IActionResult LoginSubmit(LoginUser marrNgaView)
    {
        
        if (ModelState.IsValid)
        {
            var PerdoruesiInDb = _context.Users.FirstOrDefault(u => u.Email == marrNgaView.Email);
            if (PerdoruesiInDb == null)
            {
                    // Add an error to ModelState and return to View!
            ModelState.AddModelError("Email", "Invalid Email/Password");
            return View("Login");
            }
            var hasher = new PasswordHasher<LoginUser>();
                
            // verify provided password against hash stored in db
            var result = hasher.VerifyHashedPassword(marrNgaView, PerdoruesiInDb.Password, marrNgaView.Password);
            if(result == 0)
            {
                return View("Login");
            } 
            
            HttpContext.Session.SetInt32("UserId", PerdoruesiInDb.UserId);
            int? session = HttpContext.Session.GetInt32("UserId");
           
            return RedirectToAction("Success",new{id=session});
        }
          
           
        
    return View("Login");
    }

    [HttpGet("Success/{id}")]
    public IActionResult Success(int id)
    {   
        //nese session i UserId ekziston me ridrjeto tek Login. dmth logohu prap.
     HttpContext.Session.GetInt32("UserId");
     if (HttpContext.Session.GetInt32("UserId") == id)
     {
        return View();
     }
        //perndryshe nese ekziton kjo adrese emaili si session
       return RedirectToAction ("login");
    }
    [HttpGet("logout")]
    public IActionResult Logout()
    {

        HttpContext.Session.Clear();
        return RedirectToAction("Login");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TestiIm.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;


namespace TestiIm.Controllers;

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
        if(HttpContext.Session.GetInt32("userId") == null)
        {
            return RedirectToAction("Register");
        }
        // ViewBag.Iloguari = _context.Users.FirstOrDefault(i => i.UserId == Id);
        int id = (int)HttpContext.Session.GetInt32("userId");
    ViewBag.Hobbies = _context.Hobbies.Include(e => e.Enthusiasts).OrderBy( e => e.Enthusiasts.Count());
        ViewBag.iLoguari = _context.Users.FirstOrDefault(e=> e.UserId == id);
        ViewBag.AllHobies =_context.Hobbies.Include(m => m.Creator).Include(e => e.Enthusiasts)
        .OrderByDescending(e => e.CreatedAt).ToList();
        
        ViewBag.AllHobbies = _context.Hobbies.Include(c=>c.Enthusiasts).ThenInclude(c=>c.UseriThatLikes);
        
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    [HttpGet("Show/{id}")]
    public IActionResult Show(int id)
    {   
        
        Hobbie marrNgaDb = _context.Hobbies.FirstOrDefault(e => e.HobbieId == id);
        return View("show",marrNgaDb);
    }
      


    [HttpGet("Register")]
    public IActionResult Register()     
    {
              if(HttpContext.Session.GetInt32("userId") == null)
            {
                
              return View();
            }
        return RedirectToAction("");
    }
    [HttpPost("Register")]
    public IActionResult Register(User user)
    {
        if (ModelState.IsValid)
        {
            //nqs ndonje user ne database (ku u kap userName ) eshte e njejte me userin qe po logohet
            //ktheje prap tek registri dhe nxirrr errorin.
            if(_context.Users.Any(u => u.UserName == user.UserName))
            {                           //errori kapet nga "UserName" qe e merr nga Modeli, dhe pas presjes vendoset errori
                ModelState.AddModelError("UserName", "UserName already in use!");
               
                return View();
            }
            //hashoet paswordi para logimit
            PasswordHasher<User> Hasher = new PasswordHasher<User>();
            //kjo do te thote hasho paswordin e user duke e kap me eser.Password.
            user.Password = Hasher.HashPassword(user, user.Password);
            //shton ne database tek Users(qe e kemi tek mycontext) shton user nga Modeli jone User -> "shiko rreshtin 44"
             _context.Users.Add(user);
             //ruan ndryshimet pasi e shtuam
            _context.SaveChanges();
            //vendoset seesion duke vendos si kusht User id -> kapet me userId ne thojza qe si tek modeli, pas presjes
            // user.UserId qe kontrollon UserId e e atij qe po logohet pra user qe krijuam tek funksioni rreshti 44.
            HttpContext.Session.SetInt32("userId", user.UserId );
            //te ridrejton tek indeksi ku duam te logohemi
            return RedirectToAction("");
        }
        //perndryshe nese kushtet nuk jane plotesuar te con prap tek register qe ti fusesh dhe nje here te dhenat.
        return View();
    }
// Tani po ndertoj partials per register dhe login ne htmlcss dhe do kthehem prap.
    // Register funksionon pasi ne workbench me shfaqet useri i pare Albert Prenga
    // Vazhdojme me login

    [HttpPost("Login")]

    public IActionResult LoginSubmit(LoginUser userSubmission)
    {
        if (ModelState.IsValid)
        {
            //Nese Modeli eshte valid kerko nese ekziston i njejti username ne database qe nese eshte te logohet nese jo te registrohet tek registgri
            var userInDb = _context.Users.FirstOrDefault(u => u.UserName == userSubmission.UserName);
            if (userInDb == null)
            {   //pra nqs ky qe po logohet nuk eshte ne database te regjisrohet urgjent se ndryshe s'futet.
                ModelState.AddModelError("User", "Invalid UserName of Password");
                return View("Register");
            }
            var Hasher = new PasswordHasher<LoginUser>(); //verifikohet paswordi me paswordin e hashuar ne database
            var result = Hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.Password);
            if (result == 0)
            {
                ModelState.AddModelError("Password", "Invalid Password");
                return View("Register");
            }//pasi kalohet dhe ky kusht qe paswordi eshte i njejte vendoset session ne logim
            HttpContext.Session.SetInt32("userId", userInDb.UserId);
            return RedirectToAction("index");
        }
        return View("Register");
    }



    [HttpGet("Logout")]
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction ("Register");
    }
    // Ketu fillojme me shfaqjen e listes se filmave ne faqen tone kryesore index.
    // para index duhet te hapim nje cshtml MovieAdd ku do te japim te dhenat e filmit qe do shtojme

    [HttpGet("Hobbie/Add")]
    public IActionResult HobbieAdd()
    {
        return View(); //na drejton tek MovieAdd.cshtml per formen e shtimit te filmit.
    }

    [HttpPost("/Hobbie/Add")]
    public IActionResult HobbieCreate (Hobbie marrNgaView)
    {
        if(ModelState.IsValid)
        { //ne menyre qe te shtohen nga i loguari dhe te kapet Id fusim session me int id
            int id = (int)HttpContext.Session.GetInt32("userId");
            marrNgaView.UserId = id;
            _context.Hobbies.Add(marrNgaView);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
        return View("HobbieAdd");
    }
    //tani punojme me "MovieAdd.cshtml" dhe index.cshtml ku kapim filmin me viewbag dhe e shtojme tek index

    //pasi perfundojme na duhet te shtojme fansat dhe edit delete
    // [HttpGet("/Hobbie/BeEnthusiast/{id}")]
    // public IActionResult AddFun(int id)
    // {
    //     ViewBag.id = id;
    //     return View();
    // }
        [HttpGet("/Hobbie/Fans/{id}")]
        public IActionResult FansAdd(int id){
        if(HttpContext.Session.GetInt32("userId") == null){
            return RedirectToAction("Register");
            }
        int id2 = (int)HttpContext.Session.GetInt32("userId");

        ViewBag.iLoguari = _context.Users.FirstOrDefault(e=> e.UserId == id2);        
        ViewBag.id=id;
        Console.WriteLine(ViewBag.id);
        return View("show");
    }
        [HttpPost("Hobbie/BehuFans/{id}")]
    public IActionResult BehuFans(int id,string type){
        int idFromSession = (int)HttpContext.Session.GetInt32("userId");
        Enthusiast fansIRI = new Enthusiast(){
            UserId = idFromSession,
            HobbieId = id,
            Type= type,
            
        };
        _context.Enthusiasts.Add(fansIRI);
        _context.SaveChanges();
        return RedirectToAction("index");

    }  

    // [HttpPost("BeEnthusiast/{id}")]
    // public IActionResult BeEnthusiast(int id, string type)
    // {
      
    //     int idFromSession = (int)HttpContext.Session.GetInt32("userId");
    //     Enthusiast NewEnthusiast = new Enthusiast()
    //     {
    //         UserId = idFromSession,
    //         HobbieId = id,
    //         Type = type
    //     };
    //     _context.Enthusiasts.Add(NewEnthusiast);
    //     _context.SaveChanges();
    //     return RedirectToAction ("index");
    // } 

    // [HttpGet("/MosPelqe/{id}")]
    // public IActionResult MosePelqe(int id)
    // {
    //     Enthusiast enthNo = _context.Enthusiasts.First(u => u.HobbieId == id);
    //     _context.Enthusiasts.Remove(enthNo);
    //     _context.SaveChanges();
    //     return RedirectToAction("index");
    // }

    // [HttpGet("/Movie/Delete/{id}")]
    // public IActionResult Fshi(int id)
    // {
    //     Movie marrNgaDb = _context.Movies.First(i => i.MovieId == id);
    //     _context.Movies.Remove(marrNgaDb);
    //     _context.SaveChanges();
    //     return RedirectToAction("index"); }
    

    [HttpGet("Edit/{id}")]
    public IActionResult Edit(int id)
    {
        Hobbie NewHobbie = _context.Hobbies.First(f => f.HobbieId == id);
        return View("Edit", NewHobbie);
    }
    [HttpPost("Edit/Update/{id}")]
    public IActionResult Update(int id, Hobbie EditHobbie)
    {
        if(ModelState.IsValid)
        {
            Hobbie NewHobbie = _context.Hobbies.First(i => i.HobbieId == id);
            NewHobbie.Name = EditHobbie.Name;
            NewHobbie.Description = EditHobbie.Description;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View("Edit");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

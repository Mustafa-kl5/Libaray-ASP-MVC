using Libaray.Models;
using Microsoft.AspNetCore.Mvc;

namespace Libaray.Controllers
{

    public class AuthController : Controller
    {
        private readonly LibaraySystemContext _systemContext;
        public AuthController(LibaraySystemContext systemContext)
        {
              _systemContext = systemContext;
        }
        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registration(User NewUser)
        {
            _systemContext.Add(NewUser);
            _systemContext.SaveChanges();
            return RedirectToAction("Index", "Categories");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
            var exsistUser = _systemContext.Users.FirstOrDefault((u) => u.Email == user.Email && u.Password == user.Password);
            if (exsistUser != null) {  
                return RedirectToAction("Index", "Categories"); 
            }
            else {
                ViewBag.errorMassage = "wrong email or password";
                return View();
            }
           
        }
    }
}

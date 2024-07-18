using BeeMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BeeMVC.Controllers
{
    public class SignUpController : Controller
    {
        public BeeDbContext db { get; set; }
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(Login login)
        {
            //db.Signup.InsertOne(login);
            return View();
        }

        [HttpGet]
        public IActionResult RegisterView()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Register register)
        {
            db.Signup.InsertOne(register);
            return View();
        }
    }
}

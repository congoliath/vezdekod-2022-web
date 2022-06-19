using Microsoft.AspNetCore.Mvc;
using Vezdekod.ContextFolder;
using Vezdekod.Models;

namespace Vezdekod.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignIn(string email, string password)
        {
            using (var db = new DataContext())
            {
                if (db.Users.Where(x=>x.Email == email).Where(x=>x.Password==password).FirstOrDefault()!=null)
                {
                    return Redirect("~/Index/Index");
                }
                return Redirect("~/Login/Login");
            }
        }
    }
}

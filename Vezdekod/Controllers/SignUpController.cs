using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vezdekod.ContextFolder;
using Vezdekod.Models;

namespace Vezdekod.Controllers
{
    public class SignUpController : Controller
    {
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAccount(string surname, string name,string email, string password)
        {
            using (var db = new DataContext())
            {
                db.Users.Add(
                    new User()
                    {
                        Surname = surname,
                        Name = name,
                        Email = email,
                        Password = password

                    });
                db.SaveChanges();
            }

            return Redirect("~/Login/Login");
        }
    }
}

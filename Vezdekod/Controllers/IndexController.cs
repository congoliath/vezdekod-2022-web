using Microsoft.AspNetCore.Mvc;

namespace Vezdekod.Controllers
{
    public class IndexController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}

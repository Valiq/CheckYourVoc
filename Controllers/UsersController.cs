using Microsoft.AspNetCore.Mvc;

namespace CheckYourVoc.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

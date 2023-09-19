using Microsoft.AspNetCore.Mvc;

namespace CheckYourVoc.Controllers
{
    public class VocabularyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

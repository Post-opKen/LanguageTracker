using Microsoft.AspNetCore.Mvc;

namespace LanguageTracker.Controllers
{
    public class LanguageTrackerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Students()
        {
            return "I am the students view";
        }
    }
}
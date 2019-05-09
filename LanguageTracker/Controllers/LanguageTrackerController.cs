using Microsoft.AspNetCore.Mvc;

namespace LanguageTracker.Controllers
{
    public class LanguageTrackerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Students()
        {
			return View();
        }
    }
}
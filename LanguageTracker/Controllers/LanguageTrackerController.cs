using Microsoft.AspNetCore.Mvc;

/**
 * This class sets up the views/routes for the web app
 * */
namespace LanguageTracker.Controllers
{
    public class LanguageTrackerController : Controller
    {
		//default route
        public IActionResult Index()
        {
            return View();
        }

		//individual students route
        public IActionResult Students()
        {
			return View();
        }

        //excel upload route
        public IActionResult Upload()
        {
            return View();
        }
    }
}
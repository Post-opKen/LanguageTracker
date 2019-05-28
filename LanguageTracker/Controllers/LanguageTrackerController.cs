using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

/**
 * This class sets up the views/routes for the web app
 * */
namespace LanguageTracker.Controllers
{
    public class LanguageTrackerController : Controller
    {
		//default constructor
		public LanguageTrackerController()
		{
			//empty for a purpose
		}

		//default route
		public IActionResult Index()
        {
            ViewData["tabIndex"] = "currentPage";
            ViewData["tabStudents"] = "";
            ViewData["tabUpload"] = "";
            return View();
        }

        //individual students route
        public IActionResult Students()
        {
            ViewData["tabIndex"] = "";
            ViewData["tabStudents"] = "currentPage";
            ViewData["tabUpload"] = "";
            return View();
        }

        //excel upload route
        public IActionResult Upload()
        {
            ViewData["tabIndex"] = "";
            ViewData["tabStudents"] = "";
            ViewData["tabUpload"] = "currentPage";
            return View();
        }

        //import CSV file from the Upload route
        [HttpPost]
        public IActionResult Import(IFormFile excelFile)
        {
			Stream stream = excelFile.OpenReadStream();
			ViewData["table"] = ReadFile(stream); 

			return View();
        }

		//method to read the file and convert it to a table
		public static bool ReadFile(Stream stream)
		{
			if (stream != null)
			{
				StreamReader reader = new StreamReader(stream);
				//display the file as an html table
				string table = "";
				while (!reader.EndOfStream)
				{
					table += "<tr>";
					string line = reader.ReadLine();
					string[] cols = line.Split(",");
					foreach (string col in cols)
					{
						table += $"<td>{col}</td>";
					}
					table += "</tr>";
				}
				//ViewData["table"] = table;
				return true;
			}
			else
			{
				return false;
			}
		}
    }
}
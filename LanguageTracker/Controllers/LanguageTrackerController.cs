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
        //Columns for the file upload
        const string ACTFL_COLS = "YearQuarterID,Language,ItemNumber,SID,SPEAKING,WRITING,LISTENING,READING";

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
            //open file stream and reader
            Stream stream = excelFile.OpenReadStream();
            StreamReader reader = new StreamReader(stream);
            string output = "";

            //check for file type and column format
            string columns = reader.ReadLine();
            if (!excelFile.FileName.EndsWith(".csv") || columns != ACTFL_COLS)
            {
                output = "Must be  .csv file with the following columns: \n YearQuarterID, Language, ItemNumber, SID, SPEAKING, WRITING, LISTENING, READING";
            }
            else
            {
                //display the file as an html table
                while (!reader.EndOfStream)
                {
                    output += "<tr>";
                    string line = reader.ReadLine();
                    string[] cols = line.Split(",");
                    foreach (string col in cols)
                    {
                        output += $"<td>{col}</td>";
                    }
                    output += "</tr>";
                }
            }

            //set a template variable and return
            ViewData["table"] = output;
            return View();
        }
    }
}
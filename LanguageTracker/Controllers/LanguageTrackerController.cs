﻿using Microsoft.AspNetCore.Http;
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

        //import CSV file from the Upload route
        [HttpPost]
        public IActionResult Import(IFormFile excelFile)
        {
            Stream stream = excelFile.OpenReadStream();
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
            ViewData["table"] = table;
            return View();
        }
    }
}
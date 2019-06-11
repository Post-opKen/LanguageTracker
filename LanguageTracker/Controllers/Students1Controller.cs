using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LanguageTracker.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace LanguageTracker.Controllers
{
	public class Students1Controller : Controller
	{
		private readonly LanguageTrackerContext _context;

		public Students1Controller(LanguageTrackerContext context)
		{
			_context = context;
		}

		// GET: Students1
		public async Task<IActionResult> Index()
		{
			ViewData["tabIndex"] = "";
			ViewData["tabStudents"] = "";
			ViewData["tabUpload"] = "currentPage";
			return View(await _context.Student.ToListAsync());
		}

		// GET: Students1/Details/5
		public async Task<IActionResult> Details(string id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var student = await _context.Student
				.FirstOrDefaultAsync(m => m.SID == id);
			if (student == null)
			{
				return NotFound();
			}

			return View(student);
		}

		// GET: Students1/Create
		public IActionResult Create()
		{
			return View();
		}

		// POST: Students1/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("SID,FullName")] Student student)
		{
			if (ModelState.IsValid)
			{
				_context.Add(student);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			return View(student);
		}

		[HttpPost]
		public async Task<IActionResult> Import(IFormFile excelFile)
		{
			//open file stream and reader
			Stream stream = excelFile.OpenReadStream();
			StreamReader reader = new StreamReader(stream);
			string output = "";

			//check for file type and column format
			string columns = reader.ReadLine();
			if (!excelFile.FileName.EndsWith(".csv"))
			{
				output = "Must be  .csv file with the following columns: \n YearQuarterID, Language, ItemNumber, SID, SPEAKING, WRITING, LISTENING, READING";
			}
			else
			{
				//display the file as an html table
				while (!reader.EndOfStream)
				{
					string line = reader.ReadLine();
					string[] cols = line.Split(",");
					Student student = new Student();
					if (ModelState.IsValid)
					{
						student.SID = cols[0];
						student.FullName = cols[1];
						_context.Add(student);
						await _context.SaveChangesAsync();
					}
				}
			}

			//set a template variable and return
			ViewData["table"] = output;
			return RedirectToAction(nameof(Index));
		}

		// GET: Students1/Edit/5
		public async Task<IActionResult> Edit(string id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var student = await _context.Student.FindAsync(id);
			if (student == null)
			{
				return NotFound();
			}
			return View(student);
		}

		// POST: Students1/Edit/5
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(string id, [Bind("SID,FullName")] Student student)
		{
			if (id != student.SID)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					_context.Update(student);
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!StudentExists(student.SID))
					{
						return NotFound();
					}
					else
					{
						throw;
					}
				}
				return RedirectToAction(nameof(Index));
			}
			return View(student);
		}

		// GET: Students1/Delete/5
		public async Task<IActionResult> Delete(string id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var student = await _context.Student
				.FirstOrDefaultAsync(m => m.SID == id);
			if (student == null)
			{
				return NotFound();
			}

			return View(student);
		}

		// POST: Students1/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(string id)
		{
			var student = await _context.Student.FindAsync(id);
			_context.Student.Remove(student);
			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool StudentExists(string id)
		{
			return _context.Student.Any(e => e.SID == id);
		}
	}
}

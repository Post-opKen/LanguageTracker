using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LanguageTracker.Models;

namespace LanguageTracker.Controllers
{
    public class ACTFLController : Controller
    {
        private readonly LanguageTrackerContext _context;

        public ACTFLController(LanguageTrackerContext context)
        {
            _context = context;
        }

        // GET: ACTFL
        public async Task<IActionResult> Index()
        {
            var languageTrackerContext = _context.ACTFL.Include(a => a.S);
            return View(await languageTrackerContext.ToListAsync());
        }

        // GET: ACTFL/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aCTFL = await _context.ACTFL
                .Include(a => a.S)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (aCTFL == null)
            {
                return NotFound();
            }

            return View(aCTFL);
        }

        // GET: ACTFL/Create
        public IActionResult Create()
        {
            ViewData["SID"] = new SelectList(_context.Enrollment, "SID", "SID");
            return View();
        }

        // POST: ACTFL/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,YearQuarterID,Language,ItemNumber,SID,Reading,Writing,Speaking,Listening")] ACTFL aCTFL)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aCTFL);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SID"] = new SelectList(_context.Enrollment, "SID", "SID", aCTFL.SID);
            return View(aCTFL);
        }

        // GET: ACTFL/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aCTFL = await _context.ACTFL.FindAsync(id);
            if (aCTFL == null)
            {
                return NotFound();
            }
            ViewData["SID"] = new SelectList(_context.Enrollment, "SID", "SID", aCTFL.SID);
            return View(aCTFL);
        }

        // POST: ACTFL/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,YearQuarterID,Language,ItemNumber,SID,Reading,Writing,Speaking,Listening")] ACTFL aCTFL)
        {
            if (id != aCTFL.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aCTFL);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ACTFLExists(aCTFL.ID))
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
            ViewData["SID"] = new SelectList(_context.Enrollment, "SID", "SID", aCTFL.SID);
            return View(aCTFL);
        }

        // GET: ACTFL/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aCTFL = await _context.ACTFL
                .Include(a => a.S)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (aCTFL == null)
            {
                return NotFound();
            }

            return View(aCTFL);
        }

        // POST: ACTFL/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aCTFL = await _context.ACTFL.FindAsync(id);
            _context.ACTFL.Remove(aCTFL);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ACTFLExists(int id)
        {
            return _context.ACTFL.Any(e => e.ID == id);
        }
    }
}

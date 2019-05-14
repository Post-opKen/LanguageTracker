using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LanguageTracker.Controllers;
using LanguageTracker.Models;

namespace LanguageTracker
{
    public class LabHoursController : Controller
    {
        private readonly LanguageTrackerContext _context;

        public LabHoursController(LanguageTrackerContext context)
        {
            _context = context;
        }

        // GET: LabHours
        public async Task<IActionResult> Index()
        {
            return View(await _context.LabHours.ToListAsync());
        }

        // GET: LabHours/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var labHours = await _context.LabHours
                .FirstOrDefaultAsync(m => m.Id == id);
            if (labHours == null)
            {
                return NotFound();
            }

            return View(labHours);
        }

        // GET: LabHours/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LabHours/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,instructors,sid,total_days,total_hours")] LabHours labHours)
        {
            if (ModelState.IsValid)
            {
                _context.Add(labHours);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(labHours);
        }

        // GET: LabHours/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var labHours = await _context.LabHours.FindAsync(id);
            if (labHours == null)
            {
                return NotFound();
            }
            return View(labHours);
        }

        // POST: LabHours/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,instructors,sid,total_days,total_hours")] LabHours labHours)
        {
            if (id != labHours.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(labHours);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LabHoursExists(labHours.Id))
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
            return View(labHours);
        }

        // GET: LabHours/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var labHours = await _context.LabHours
                .FirstOrDefaultAsync(m => m.Id == id);
            if (labHours == null)
            {
                return NotFound();
            }

            return View(labHours);
        }

        // POST: LabHours/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var labHours = await _context.LabHours.FindAsync(id);
            _context.LabHours.Remove(labHours);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LabHoursExists(int id)
        {
            return _context.LabHours.Any(e => e.Id == id);
        }
    }
}

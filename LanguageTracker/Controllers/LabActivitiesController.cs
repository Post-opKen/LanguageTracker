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
    public class LabActivitiesController : Controller
    {
        private readonly LanguageTrackerContext _context;

        public LabActivitiesController(LanguageTrackerContext context)
        {
            _context = context;
        }

        // GET: LabActivities
        public async Task<IActionResult> Index()
        {
            return View(await _context.LabActivities.ToListAsync());
        }

        // GET: LabActivities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var labActivities = await _context.LabActivities
                .FirstOrDefaultAsync(m => m.sid == id);
            if (labActivities == null)
            {
                return NotFound();
            }

            return View(labActivities);
        }

        // GET: LabActivities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LabActivities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("sid,last_name,first_name,date,activity,staff_levels")] LabActivities labActivities)
        {
            if (ModelState.IsValid)
            {
                _context.Add(labActivities);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(labActivities);
        }

        // GET: LabActivities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var labActivities = await _context.LabActivities.FindAsync(id);
            if (labActivities == null)
            {
                return NotFound();
            }
            return View(labActivities);
        }

        // POST: LabActivities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("sid,last_name,first_name,date,activity,staff_levels")] LabActivities labActivities)
        {
            if (id != labActivities.sid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(labActivities);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LabActivitiesExists(labActivities.sid))
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
            return View(labActivities);
        }

        // GET: LabActivities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var labActivities = await _context.LabActivities
                .FirstOrDefaultAsync(m => m.sid == id);
            if (labActivities == null)
            {
                return NotFound();
            }

            return View(labActivities);
        }

        // POST: LabActivities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var labActivities = await _context.LabActivities.FindAsync(id);
            _context.LabActivities.Remove(labActivities);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LabActivitiesExists(int id)
        {
            return _context.LabActivities.Any(e => e.sid == id);
        }
    }
}

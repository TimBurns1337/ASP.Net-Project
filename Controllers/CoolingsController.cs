using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASP.Net_project.Data;
using ASP.Net_project.Models;

namespace ASP.Net_project.Controllers
{
    public class CoolingsController : Controller
    {
        private readonly ComputerContext _context;

        public CoolingsController(ComputerContext context)
        {
            _context = context;
        }

        // GET: Coolings
        public async Task<IActionResult> Index()
        {
            return View(await _context.Coolings.ToListAsync());
        }

        // GET: Coolings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cooling = await _context.Coolings
                .FirstOrDefaultAsync(m => m.CoolingId == id);
            if (cooling == null)
            {
                return NotFound();
            }

            return View(cooling);
        }

        // GET: Coolings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Coolings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CoolingId,CoolingName,CoolingPrice,ImageLink")] Cooling cooling)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cooling);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cooling);
        }

        // GET: Coolings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cooling = await _context.Coolings.FindAsync(id);
            if (cooling == null)
            {
                return NotFound();
            }
            return View(cooling);
        }

        // POST: Coolings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CoolingId,CoolingName,CoolingPrice,ImageLink")] Cooling cooling)
        {
            if (id != cooling.CoolingId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cooling);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CoolingExists(cooling.CoolingId))
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
            return View(cooling);
        }

        // GET: Coolings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cooling = await _context.Coolings
                .FirstOrDefaultAsync(m => m.CoolingId == id);
            if (cooling == null)
            {
                return NotFound();
            }

            return View(cooling);
        }

        // POST: Coolings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cooling = await _context.Coolings.FindAsync(id);
            _context.Coolings.Remove(cooling);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CoolingExists(int id)
        {
            return _context.Coolings.Any(e => e.CoolingId == id);
        }
    }
}

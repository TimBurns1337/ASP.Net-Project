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
    public class GamingPCsController : Controller
    {
        private readonly ComputerContext _context;

        public GamingPCsController(ComputerContext context)
        {
            _context = context;
        }

        // GET: GamingPCs
        public async Task<IActionResult> Index()
        {
            return View(await _context.GamingPCs.ToListAsync());
        }

        // GET: GamingPCs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gamingPC = await _context.GamingPCs
                .FirstOrDefaultAsync(m => m.GamingPCId == id);
            if (gamingPC == null)
            {
                return NotFound();
            }

            return View(gamingPC);
        }

        // GET: GamingPCs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GamingPCs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GamingPCId,Componets,Summary,Name,ImageLink,Price")] GamingPC gamingPC)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gamingPC);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gamingPC);
        }

        // GET: GamingPCs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gamingPC = await _context.GamingPCs.FindAsync(id);
            if (gamingPC == null)
            {
                return NotFound();
            }
            return View(gamingPC);
        }

        // POST: GamingPCs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GamingPCId,Componets,Summary,Name,ImageLink,Price")] GamingPC gamingPC)
        {
            if (id != gamingPC.GamingPCId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gamingPC);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GamingPCExists(gamingPC.GamingPCId))
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
            return View(gamingPC);
        }

        // GET: GamingPCs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gamingPC = await _context.GamingPCs
                .FirstOrDefaultAsync(m => m.GamingPCId == id);
            if (gamingPC == null)
            {
                return NotFound();
            }

            return View(gamingPC);
        }

        // POST: GamingPCs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gamingPC = await _context.GamingPCs.FindAsync(id);
            _context.GamingPCs.Remove(gamingPC);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GamingPCExists(int id)
        {
            return _context.GamingPCs.Any(e => e.GamingPCId == id);
        }
    }
}

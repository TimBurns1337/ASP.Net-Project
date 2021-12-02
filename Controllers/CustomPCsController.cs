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
    public class CustomPCsController : Controller
    {
        private readonly ComputerContext _context;

        public CustomPCsController(ComputerContext context)
        {
            _context = context;
        }

        // GET: CustomPCs
        public async Task<IActionResult> Index()
        {
            return View(await _context.CustomPC.ToListAsync());
        }

        // GET: CustomPCs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customPC = await _context.CustomPC
                .FirstOrDefaultAsync(m => m.CustomPcId == id);
            if (customPC == null)
            {
                return NotFound();
            }

            return View(customPC);
        }

        // GET: CustomPCs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CustomPCs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomPcId,Cpu,CpuPrice,Gpu,GpuPrice,MotherBoard,MotherBoardPrice,Ram,RamPrice,Hdd,HddPrice,Power,PowerPrice,Cooling,CoolingPrice,Case,CasePrice")] CustomPC customPC)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customPC);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customPC);
        }

        // GET: CustomPCs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customPC = await _context.CustomPC.FindAsync(id);
            if (customPC == null)
            {
                return NotFound();
            }
            return View(customPC);
        }

        // POST: CustomPCs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomPcId,Cpu,CpuPrice,Gpu,GpuPrice,MotherBoard,MotherBoardPrice,Ram,RamPrice,Hdd,HddPrice,Power,PowerPrice,Cooling,CoolingPrice,Case,CasePrice")] CustomPC customPC)
        {
            if (id != customPC.CustomPcId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customPC);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomPCExists(customPC.CustomPcId))
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
            return View(customPC);
        }

        // GET: CustomPCs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customPC = await _context.CustomPC
                .FirstOrDefaultAsync(m => m.CustomPcId == id);
            if (customPC == null)
            {
                return NotFound();
            }

            return View(customPC);
        }

        // POST: CustomPCs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customPC = await _context.CustomPC.FindAsync(id);
            _context.CustomPC.Remove(customPC);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomPCExists(int id)
        {
            return _context.CustomPC.Any(e => e.CustomPcId == id);
        }
    }
}

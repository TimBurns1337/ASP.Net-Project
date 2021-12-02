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
    public class MotherBoardsController : Controller
    {
        private readonly ComputerContext _context;

        public MotherBoardsController(ComputerContext context)
        {
            _context = context;
        }

        // GET: MotherBoards
        public async Task<IActionResult> Index()
        {
            return View(await _context.MotherBoards.ToListAsync());
        }

        // GET: MotherBoards/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motherBoard = await _context.MotherBoards
                .FirstOrDefaultAsync(m => m.MotherBoardId == id);
            if (motherBoard == null)
            {
                return NotFound();
            }

            return View(motherBoard);
        }

        // GET: MotherBoards/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MotherBoards/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MotherBoardId,MotherBoardName,MotherBoardPrice,ImageLink")] MotherBoard motherBoard)
        {
            if (ModelState.IsValid)
            {
                _context.Add(motherBoard);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(motherBoard);
        }

        // GET: MotherBoards/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motherBoard = await _context.MotherBoards.FindAsync(id);
            if (motherBoard == null)
            {
                return NotFound();
            }
            return View(motherBoard);
        }

        // POST: MotherBoards/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MotherBoardId,MotherBoardName,MotherBoardPrice,ImageLink")] MotherBoard motherBoard)
        {
            if (id != motherBoard.MotherBoardId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(motherBoard);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MotherBoardExists(motherBoard.MotherBoardId))
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
            return View(motherBoard);
        }

        // GET: MotherBoards/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motherBoard = await _context.MotherBoards
                .FirstOrDefaultAsync(m => m.MotherBoardId == id);
            if (motherBoard == null)
            {
                return NotFound();
            }

            return View(motherBoard);
        }

        // POST: MotherBoards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var motherBoard = await _context.MotherBoards.FindAsync(id);
            _context.MotherBoards.Remove(motherBoard);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MotherBoardExists(int id)
        {
            return _context.MotherBoards.Any(e => e.MotherBoardId == id);
        }
    }
}

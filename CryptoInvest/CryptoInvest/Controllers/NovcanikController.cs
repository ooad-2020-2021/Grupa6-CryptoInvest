using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CryptoInvestt.Models;
using CryptoInvest.Data;

namespace CryptoInvestt.Controllers
{
    public class NovcanikController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NovcanikController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Novcanik
        public async Task<IActionResult> Index()
        {
            return View(await _context.Novcanik.ToListAsync());
        }

        // GET: Novcanik/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var novcanik = await _context.Novcanik
                .FirstOrDefaultAsync(m => m.ID == id);
            if (novcanik == null)
            {
                return NotFound();
            }

            return View(novcanik);
        }

        // GET: Novcanik/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Novcanik/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,iznosi,UkupniIznos")] Novcanik novcanik)
        {
            if (ModelState.IsValid)
            {
                _context.Add(novcanik);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(novcanik);
        }

        // GET: Novcanik/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var novcanik = await _context.Novcanik.FindAsync(id);
            if (novcanik == null)
            {
                return NotFound();
            }
            return View(novcanik);
        }

        // POST: Novcanik/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,iznosi,UkupniIznos")] Novcanik novcanik)
        {
            if (id != novcanik.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(novcanik);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NovcanikExists(novcanik.ID))
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
            return View(novcanik);
        }

        // GET: Novcanik/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var novcanik = await _context.Novcanik
                .FirstOrDefaultAsync(m => m.ID == id);
            if (novcanik == null)
            {
                return NotFound();
            }

            return View(novcanik);
        }

        // POST: Novcanik/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var novcanik = await _context.Novcanik.FindAsync(id);
            _context.Novcanik.Remove(novcanik);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NovcanikExists(int id)
        {
            return _context.Novcanik.Any(e => e.ID == id);
        }
    }
}

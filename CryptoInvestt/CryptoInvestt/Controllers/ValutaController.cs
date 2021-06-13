using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CryptoInvestt.Data;
using CryptoInvestt.Models;

namespace CryptoInvestt.Controllers
{
    public class ValutaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ValutaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Valuta
        public async Task<IActionResult> Index()
        {
            return View(await _context.Valuta.ToListAsync());
        }

        // GET: Valuta/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var valuta = await _context.Valuta
                .FirstOrDefaultAsync(m => m.ID == id);
            if (valuta == null)
            {
                return NotFound();
            }

            return View(valuta);
        }

        // GET: Valuta/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Valuta/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Naziv,TrenutnaVrijednost")] Valuta valuta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(valuta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(valuta);
        }

        // GET: Valuta/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var valuta = await _context.Valuta.FindAsync(id);
            if (valuta == null)
            {
                return NotFound();
            }
            return View(valuta);
        }

        // POST: Valuta/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Naziv,TrenutnaVrijednost")] Valuta valuta)
        {
            if (id != valuta.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(valuta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ValutaExists(valuta.ID))
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
            return View(valuta);
        }

        // GET: Valuta/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var valuta = await _context.Valuta
                .FirstOrDefaultAsync(m => m.ID == id);
            if (valuta == null)
            {
                return NotFound();
            }

            return View(valuta);
        }

        // POST: Valuta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var valuta = await _context.Valuta.FindAsync(id);
            _context.Valuta.Remove(valuta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ValutaExists(int id)
        {
            return _context.Valuta.Any(e => e.ID == id);
        }
    }
}

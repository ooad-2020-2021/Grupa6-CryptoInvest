using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CryptoInvest.Models;
using CryptoInvest.Data;

namespace CryptoInvest.Controllers
{
    public class IznosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public IznosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Iznos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Iznos.ToListAsync());
        }

        // GET: Iznos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iznos = await _context.Iznos
                .FirstOrDefaultAsync(m => m.valutaId == id);
            if (iznos == null)
            {
                return NotFound();
            }

            return View(iznos);
        }

        // GET: Iznos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Iznos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("valutaId,kolicina")] Iznos iznos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(iznos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(iznos);
        }

        // GET: Iznos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iznos = await _context.Iznos.FindAsync(id);
            if (iznos == null)
            {
                return NotFound();
            }
            return View(iznos);
        }

        // POST: Iznos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("valutaId,kolicina")] Iznos iznos)
        {
            if (id != iznos.valutaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(iznos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IznosExists(iznos.valutaId))
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
            return View(iznos);
        }

        // GET: Iznos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iznos = await _context.Iznos
                .FirstOrDefaultAsync(m => m.valutaId == id);
            if (iznos == null)
            {
                return NotFound();
            }

            return View(iznos);
        }

        // POST: Iznos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var iznos = await _context.Iznos.FindAsync(id);
            _context.Iznos.Remove(iznos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IznosExists(int id)
        {
            return _context.Iznos.Any(e => e.valutaId == id);
        }
    }
}

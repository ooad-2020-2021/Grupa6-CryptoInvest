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
    public class KorisnikController : Controller
    {

        static List<Korisnik> korisnici = new List<Korisnik>();

        //private readonly ApplicationDbContext _context;

        public KorisnikController(ApplicationDbContext context)
        {
            //    _context = context;
            korisnici.Add(new Korisnik(1, "kerim", "sifra", "kerim16@gmail.com"));
            korisnici.Add(new Korisnik(2, "amila", "sifra", "amila16@gmail.com"));
            korisnici.Add(new Korisnik(3, "andrej", "sifra", "andrej16@gmail.com"));
        }

        // GET: Korisnik  
        public IActionResult Index()
        {
            return View(korisnici);
        }

        // GET: Korisnik/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var korisnik = korisnici //await _context.Korisnik
                .Find(m => m.ID == id);
            if (korisnik == null)
            {
                return NotFound();
            }

            return View(korisnik);
        }

        // GET: Korisnik/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Korisnik/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("ID,username,password,email")] Korisnik korisnik)
        {
            if (ModelState.IsValid)
            {
                korisnici.Add(korisnik);
                //await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(korisnik);
        }

        // GET: Korisnik/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var korisnik = korisnici.Find(m=> m.ID == id);
            if (korisnik == null)
            {
                return NotFound();
            }
            return View(korisnik);
        }

        // POST: Korisnik/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,username,password,email")] Korisnik korisnik)
        {
            if (id != korisnik.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    Korisnik k = korisnici.Find(pr => pr.ID == korisnik.ID);
                    korisnici.Remove(k);
                    korisnici.Add(korisnik);
                   // _context.Update(korisnik);
                    //await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KorisnikExists(korisnik.ID))
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
            return View(korisnik);
        }

        // GET: Korisnik/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var korisnik = korisnici
                .Find(m => m.ID == id);
            if (korisnik == null)
            {
                return NotFound();
            }

            return View(korisnik);
        }

        // POST: Korisnik/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var korisnik = korisnici.Find(p => p.ID == id);
            korisnici.Remove(korisnik);
            //await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KorisnikExists(int id)
        {
            return korisnici.Any(e => e.ID == id);
        }
    }
}

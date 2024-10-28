using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AlmeidaSebastian_ExamenProgreso1.Models;

namespace AlmeidaSebastian_ExamenProgreso1.Controllers
{
    public class AlmeidaController : Controller
    {
        private readonly SebastianAlmeidaContext _context;

        public AlmeidaController(SebastianAlmeidaContext context)
        {
            _context = context;
        }

        // GET: Almeida
        public async Task<IActionResult> Index()
        {
            return View(await _context.Almeida.ToListAsync());
        }

        // GET: Almeida/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var almeida = await _context.Almeida
                .FirstOrDefaultAsync(m => m.Id == id);
            if (almeida == null)
            {
                return NotFound();
            }

            return View(almeida);
        }

        // GET: Almeida/Create
        public IActionResult Create()
        {
            ViewData["IdCelular"] = new SelectList(_context.Celular, "IdCelular", "Modelo");
            return View();
        }

        // POST: Almeida/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Peso,DonanteOrganos,Fecha,IdCelular")] Almeida almeida)
        {
            if (ModelState.IsValid)
            {
                _context.Add(almeida);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCelular"] = new SelectList(_context.Celular, "IdCelular", "Modelo", almeida.IdCelular);
            return View(almeida);
        }

        // GET: Almeida/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var almeida = await _context.Almeida.FindAsync(id);
            if (almeida == null)
            {
                return NotFound();
            }
            return View(almeida);
        }

        // POST: Almeida/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Nombre,Peso,DonanteOrganos,Fecha,IdCelular")] Almeida almeida)
        {
            if (id != almeida.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(almeida);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlmeidaExists(almeida.Id))
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
            return View(almeida);
        }

        // GET: Almeida/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var almeida = await _context.Almeida
                .FirstOrDefaultAsync(m => m.Id == id);
            if (almeida == null)
            {
                return NotFound();
            }

            return View(almeida);
        }

        // POST: Almeida/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var almeida = await _context.Almeida.FindAsync(id);
            if (almeida != null)
            {
                _context.Almeida.Remove(almeida);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlmeidaExists(string id)
        {
            return _context.Almeida.Any(e => e.Id == id);
        }
    }
}

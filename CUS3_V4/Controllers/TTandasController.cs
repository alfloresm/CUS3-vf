using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CUS3_V4.Models;

namespace CUS3_V4.Controllers
{
    public class TTandasController : Controller
    {
        private readonly DB_A4F05E_SGIAMTPContext _context;

        public TTandasController(DB_A4F05E_SGIAMTPContext context)
        {
            _context = context;
        }

        // GET: TTandas
        public async Task<IActionResult> Index()
        {
            return View(await _context.TTanda.ToListAsync());
        }

        // GET: TTandas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tTanda = await _context.TTanda
                .FirstOrDefaultAsync(m => m.PkItCodTan == id);
            if (tTanda == null)
            {
                return NotFound();
            }

            return View(tTanda);
        }

        // GET: TTandas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TTandas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PkItCodTan,VtDescripcion,VtDescripcion1,ItGanador,VtTipoTanda,ItEstado,DtFechaHora")] TTanda tTanda)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tTanda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tTanda);
        }

        // GET: TTandas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tTanda = await _context.TTanda.FindAsync(id);
            if (tTanda == null)
            {
                return NotFound();
            }
            return View(tTanda);
        }

        // POST: TTandas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PkItCodTan,VtDescripcion,VtDescripcion1,ItGanador,VtTipoTanda,ItEstado,DtFechaHora")] TTanda tTanda)
        {
            if (id != tTanda.PkItCodTan)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tTanda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TTandaExists(tTanda.PkItCodTan))
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
            return View(tTanda);
        }

        // GET: TTandas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tTanda = await _context.TTanda
                .FirstOrDefaultAsync(m => m.PkItCodTan == id);
            if (tTanda == null)
            {
                return NotFound();
            }

            return View(tTanda);
        }

        // POST: TTandas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tTanda = await _context.TTanda.FindAsync(id);
            _context.TTanda.Remove(tTanda);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TTandaExists(int id)
        {
            return _context.TTanda.Any(e => e.PkItCodTan == id);
        }
        public async Task<IActionResult> Buscar()
        {
            return View(await _context.TTanda.ToListAsync());
        }
        public async Task<IActionResult> BuscarT(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var tTanda = await _context.TTanda.FindAsync(id);
            bool Istandaexist = _context.TTanda.Any
              (x => x.PkItCodTan == tTanda.PkItCodTan);
            if (Istandaexist == false)
            {
                ModelState.AddModelError("tanda1", "No existe tanda");
            }

            TempData["idt"] = tTanda.PkItCodTan;
            TempData["desc"] = tTanda.VtDescripcion;
            TempData["desc1"] = tTanda.VtDescripcion1;
            if (tTanda == null)
            {
                return NotFound();
            }

            //tTanda
            return RedirectToAction("Create", "TPuntajes");
        }
    }
}

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
    public class TPuntajesController : Controller
    {
        private readonly DB_A4F05E_SGIAMTPContext _context;

        public TPuntajesController(DB_A4F05E_SGIAMTPContext context)
        {
            _context = context;
        }

        // GET: TPuntajes
        public async Task<IActionResult> Index()
        {
            var dB_A4F05E_SGIAMTPContext = _context.TPuntaje.Include(t => t.FkVumtCodNavigation);
            return View(await dB_A4F05E_SGIAMTPContext.ToListAsync());
        }

        // GET: TPuntajes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tPuntaje = await _context.TPuntaje
                .Include(t => t.FkVumtCodNavigation)
                .FirstOrDefaultAsync(m => m.PkIpCodP == id);
            if (tPuntaje == null)
            {
                return NotFound();
            }

            return View(tPuntaje);
        }

        // GET: TPuntajes/Create
        public IActionResult Create()
        {
            @ViewBag.tanda = TempData["idt"];
            @ViewBag.tipo = TempData["desc"];
            @ViewBag.cat = TempData["desc1"];
            ViewData["FkVumtCod"] = new SelectList(_context.TUsuarioModalidadTanda, "PkVumtCod", "PkVumtCod");
            return View();
        }

        // POST: TPuntajes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PkIpCodP,IpPuntaje,IpNumeroJurado,FkVumtCod")] TPuntaje tPuntaje)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tPuntaje);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FkVumtCod"] = new SelectList(_context.TUsuarioModalidadTanda, "PkVumtCod", "PkVumtCod", tPuntaje.FkVumtCod);
            return View(tPuntaje);
        }

        // GET: TPuntajes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tPuntaje = await _context.TPuntaje.FindAsync(id);
            if (tPuntaje == null)
            {
                return NotFound();
            }
            ViewData["FkVumtCod"] = new SelectList(_context.TUsuarioModalidadTanda, "PkVumtCod", "PkVumtCod", tPuntaje.FkVumtCod);
            return View(tPuntaje);
        }

        // POST: TPuntajes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PkIpCodP,IpPuntaje,IpNumeroJurado,FkVumtCod")] TPuntaje tPuntaje)
        {
            if (id != tPuntaje.PkIpCodP)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tPuntaje);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TPuntajeExists(tPuntaje.PkIpCodP))
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
            ViewData["FkVumtCod"] = new SelectList(_context.TUsuarioModalidadTanda, "PkVumtCod", "PkVumtCod", tPuntaje.FkVumtCod);
            return View(tPuntaje);
        }

        // GET: TPuntajes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tPuntaje = await _context.TPuntaje
                .Include(t => t.FkVumtCodNavigation)
                .FirstOrDefaultAsync(m => m.PkIpCodP == id);
            if (tPuntaje == null)
            {
                return NotFound();
            }

            return View(tPuntaje);
        }

        // POST: TPuntajes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tPuntaje = await _context.TPuntaje.FindAsync(id);
            _context.TPuntaje.Remove(tPuntaje);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TPuntajeExists(int id)
        {
            return _context.TPuntaje.Any(e => e.PkIpCodP == id);
        }
    }
}

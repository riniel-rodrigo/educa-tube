using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using educa_tube_code.Models;

namespace educa_tube_code.Controllers
{
    public class CometariosController : Controller
    {
        private readonly AppDbContext _context;

        public CometariosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Cometario
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Comentarios.Include(c => c.Usuario);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Cometario/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cometario = await _context.Comentarios
                .Include(c => c.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cometario == null)
            {
                return NotFound();
            }

            return View(cometario);
        }

        // GET: Cometario/Create
        public IActionResult Create()
        {
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email");
            return View();
        }

        // POST: Cometario/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UsuarioId,Data,texto")] Cometario cometario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cometario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email", cometario.UsuarioId);
            return View(cometario);
        }

        // GET: Cometario/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cometario = await _context.Comentarios.FindAsync(id);
            if (cometario == null)
            {
                return NotFound();
            }
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email", cometario.UsuarioId);
            return View(cometario);
        }

        // POST: Cometario/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UsuarioId,Data,texto")] Cometario cometario)
        {
            if (id != cometario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cometario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CometarioExists(cometario.Id))
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
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email", cometario.UsuarioId);
            return View(cometario);
        }

        // GET: Cometario/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cometario = await _context.Comentarios
                .Include(c => c.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cometario == null)
            {
                return NotFound();
            }

            return View(cometario);
        }

        // POST: Cometario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cometario = await _context.Comentarios.FindAsync(id);
            if (cometario != null)
            {
                _context.Comentarios.Remove(cometario);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CometarioExists(int id)
        {
            return _context.Comentarios.Any(e => e.Id == id);
        }
    }
}

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
    public class PomodorosController : Controller
    {
        private readonly AppDbContext _context;

        public PomodorosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Pomodoro
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Pomodoros.Include(p => p.Usuario);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Pomodoro/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pomodoro = await _context.Pomodoros
                .Include(p => p.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pomodoro == null)
            {
                return NotFound();
            }

            return View(pomodoro);
        }

        // GET: Pomodoro/Create
        public IActionResult Create()
        {
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email");
            return View();
        }

        // POST: Pomodoro/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UsuarioId,Tempo,Quantidade,Bloqueia")] Pomodoro pomodoro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pomodoro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email", pomodoro.UsuarioId);
            return View(pomodoro);
        }

        // GET: Pomodoro/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pomodoro = await _context.Pomodoros.FindAsync(id);
            if (pomodoro == null)
            {
                return NotFound();
            }
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email", pomodoro.UsuarioId);
            return View(pomodoro);
        }

        // POST: Pomodoro/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UsuarioId,Tempo,Quantidade,Bloqueia")] Pomodoro pomodoro)
        {
            if (id != pomodoro.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pomodoro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PomodoroExists(pomodoro.Id))
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
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email", pomodoro.UsuarioId);
            return View(pomodoro);
        }

        // GET: Pomodoro/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pomodoro = await _context.Pomodoros
                .Include(p => p.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pomodoro == null)
            {
                return NotFound();
            }

            return View(pomodoro);
        }

        // POST: Pomodoro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pomodoro = await _context.Pomodoros.FindAsync(id);
            if (pomodoro != null)
            {
                _context.Pomodoros.Remove(pomodoro);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PomodoroExists(int id)
        {
            return _context.Pomodoros.Any(e => e.Id == id);
        }
    }
}

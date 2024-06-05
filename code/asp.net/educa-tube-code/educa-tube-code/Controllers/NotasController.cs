using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using educa_tube_code.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace educa_tube_code.Controllers
{
    [Authorize]
    public class NotasController : Controller
    {
        private readonly AppDbContext _context;

        public NotasController(AppDbContext context)
        {
            _context = context;
        }

        private int GetUserId()
        {
            return int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
        }

        // GET: Notas
        public async Task<IActionResult> Index()
        {
            int userId = GetUserId();
            var notas = await _context.Notas
                .Where(n => n.UsuarioId == userId)
                .Include(n => n.Usuario)
                .ToListAsync();
            return View(notas);
        }

        // GET: Notas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            int userId = GetUserId();
            var nota = await _context.Notas
                .Where(n => n.Id == id && n.UsuarioId == userId)
                .Include(n => n.Usuario)
                .FirstOrDefaultAsync();
            if (nota == null)
            {
                return NotFound();
            }

            return View(nota);
        }

        // GET: Notas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Notas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Titulo,Conteudo")] Nota nota)
        {
            if (ModelState.IsValid)
            {
                int userId = GetUserId();
                nota.DataCriacao = DateTime.Now;
                nota.UsuarioId = userId;
                _context.Add(nota);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nota);
        }

        // GET: Notas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            int userId = GetUserId();
            var nota = await _context.Notas
                .Where(n => n.Id == id && n.UsuarioId == userId)
                .FirstOrDefaultAsync();
            if (nota == null)
            {
                return NotFound();
            }
            return View(nota);
        }

        // POST: Notas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Titulo,Conteudo")] Nota nota)
        {
            if (id != nota.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                int userId = GetUserId();
                var notaToUpdate = await _context.Notas
                    .Where(n => n.Id == id && n.UsuarioId == userId)
                    .FirstOrDefaultAsync();
                if (notaToUpdate == null)
                {
                    return NotFound();
                }

                notaToUpdate.Titulo = nota.Titulo;
                notaToUpdate.Conteudo = nota.Conteudo;
                notaToUpdate.DataCriacao = DateTime.Now;

                try
                {
                    _context.Update(notaToUpdate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NotaExists(nota.Id))
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
            return View(nota);
        }

        // GET: Notas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            int userId = GetUserId();
            var nota = await _context.Notas
                .Where(n => n.Id == id && n.UsuarioId == userId)
                .Include(n => n.Usuario)
                .FirstOrDefaultAsync();
            if (nota == null)
            {
                return NotFound();
            }

            return View(nota);
        }

        // POST: Notas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            int userId = GetUserId();
            var nota = await _context.Notas
                .Where(n => n.Id == id && n.UsuarioId == userId)
                .FirstOrDefaultAsync();
            if (nota != null)
            {
                _context.Notas.Remove(nota);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        private bool NotaExists(int id)
        {
            return _context.Notas.Any(e => e.Id == id);
        }
    }
}

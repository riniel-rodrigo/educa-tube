using Microsoft.AspNetCore.Mvc;
using educa_tube_code.Models;
using System.Security.Claims;
using System.Data.Entity.Infrastructure;


namespace educa_tube_code.Controllers
{
    public class PerfisController : Controller
    {
        private readonly AppDbContext _context;
        public PerfisController(AppDbContext context)
        {
            _context = context;

        }

        private int GetUserId()
        {
            return int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
        }
        public IActionResult Index()
        {


            Usuario usuario = _context.Usuarios.FirstOrDefault(o => o.Id == GetUserId());
            return View(usuario);
        }
      
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();


            Usuario usuario = _context.Usuarios.FirstOrDefault(o => o.Id == GetUserId());

            if (usuario != null)
                return View(usuario);

            return NotFound();



        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Senha")] Usuario usuario)
        {
            if (id != usuario.Id)
                return NotFound();

            if (!String.IsNullOrEmpty(usuario.Nome) && !String.IsNullOrEmpty(usuario.Senha))
            {
                Usuario usuarioUpadate = _context.Usuarios.FirstOrDefault(o => o.Id == GetUserId());
                if (usuarioUpadate == null)
                {
                    return NotFound();
                }

                usuarioUpadate.Nome = usuario.Nome;
                usuarioUpadate.Senha = usuario.Senha;
                
                try
                {
                    _context.Update(usuarioUpadate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.Id))
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
            return View(usuario);
        }

        private bool UsuarioExists(int id)
        {
            return _context.Usuarios.Any(e => e.Id == id);
        }

    }
}

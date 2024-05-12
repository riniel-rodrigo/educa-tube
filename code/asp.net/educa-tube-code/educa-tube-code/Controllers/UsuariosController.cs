using educa_tube_code.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace educa_tube_code.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly AppDbContext _context;
        public UsuariosController(AppDbContext context)
        {
            _context = context;
            
        }

        public IActionResult Create()
        {
            return View();
        }
       
        [HttpPost]
        public async Task<IActionResult> Create(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                usuario.KeepLoggedIn = false;
                usuario.DataCadastro = DateTime.Now.ToString();
                _context.Usuarios.Add(usuario);
                 _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(usuario);
        }
    }
}

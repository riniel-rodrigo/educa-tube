using educa_tube_code.Models;
using Microsoft.AspNetCore.Mvc;

namespace educa_tube_code.Controllers
{
    public class PerfilController : Controller
    {
        private readonly AppDbContext _context;
        public PerfilController(AppDbContext context)
        {
            _context = context;

        }
        public IActionResult Perfil()
        {
            return View();
        }
    }
}

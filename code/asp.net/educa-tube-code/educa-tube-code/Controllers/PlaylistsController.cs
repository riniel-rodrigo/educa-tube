using educa_tube_code.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace educa_tube_code.Controllers
{
    public class PlaylistsController : Controller
    {
            private readonly AppDbContext _context;
            public PlaylistsController(AppDbContext context)
            {
                _context = context;
            }
        private int GetUserId()
        {
            return int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
        }
        public IActionResult Index()
        {
            try
            {
                var playlist = _context.Playlist.Where(o => o.Usuario.Id == GetUserId()).ToList();
                return View(playlist);
            }
            catch (Exception ex)
            {
                return View(new List<Playlist>());
            }
           
        }


    }
}


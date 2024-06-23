using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using educa_tube_code.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Google.Apis.YouTube.v3.Data;
using Playlist = educa_tube_code.Models.Playlist;

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
        private bool PlaylistExists(int id)
        {
            return _context.Playlist.Any(o => o.Id == id);
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
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Playlist playlist)
        {
            PreencherPlaylist(ref playlist);
            if (ModelState.IsValid)
            {

                _context.Playlist.Add(playlist);
                _context.SaveChanges();
                return RedirectToAction("Index", "Playlists");
            }
            return View(playlist);
        }

        public void PreencherPlaylist(ref Playlist playlist)
        {
            int userId = GetUserId();
            playlist.UsuarioId = userId;
            playlist.Usuario = _context.Usuarios.FirstOrDefault(o => o.Id == userId);
            playlist.DataCadastro = DateTime.Now;
            playlist.Url = "";
            playlist.ThumbnailUrl = "";
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();


            Playlist playlist = _context.Playlist.FirstOrDefault(o => o.Id == id);

            if (playlist != null)
                return View(playlist);

            return NotFound();

        }

        [HttpPost, ActionName("DeleteConfirmed")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            var playlist = _context.Playlist.FirstOrDefault(o => o.Id == id);
            if (playlist != null)
            {
                _context.Playlist.Remove(playlist);
                _context.SaveChanges();
            }
            return RedirectToAction("Index", "Playlists");

        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            Playlist playlist = _context.Playlist.FirstOrDefault(o => o.Id == id);

            if (playlist != null)
                return View(playlist);

            return NotFound();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Playlist playlist)
        {


            PreencherPlaylist(ref playlist);
            if (ModelState.IsValid)
            {
                int userId = GetUserId();
                var playlistToUpdate = await _context.Playlist
                    .Where(o => o.Id == playlist.Id && o.UsuarioId == userId)
                    .FirstOrDefaultAsync();
                if (playlistToUpdate == null)
                {
                    return NotFound();
                }
                playlistToUpdate.Titulo = playlist.Titulo;
                playlistToUpdate.Descricao = playlist.Descricao;


                try
                {
                    _context.Update(playlistToUpdate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlaylistExists(playlist.Id))
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
            return View(playlist);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            List<VideoPlaylist> list = _context.VideoPlaylist.Where(o => o.PlaylistId == id).ToList();
            

            return View(list);


        }
        /// <summary>
        /// Comentado para possivel utilização quando se resolver as adicções de video
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //public IActionResult AddVideo(int id)
        //{
        //    VideoPlaylist videoPlaylist = new VideoPlaylist();
        //    videoPlaylist.playlist = _context.Playlist.FirstOrDefault(o => o.Id == id);
        //    videoPlaylist.PlaylistId = id;
        //    return View(videoPlaylist);
        //}

    }
}


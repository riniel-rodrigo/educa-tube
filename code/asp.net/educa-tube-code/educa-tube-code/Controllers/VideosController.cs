using Microsoft.AspNetCore.Mvc;
using educa_tube_code.Services;
using System.Threading.Tasks;
using System.Collections.Generic;
using educa_tube_code.Models;

namespace educa_tube_code.Controllers
{
    public class VideosController : Controller
    {
        private readonly YouTubeApiService _youTubeService;

        public VideosController(YouTubeApiService youTubeService)
        {
            _youTubeService = youTubeService;
        }

        public async Task<IActionResult> Index(string query)
        {
            List<Video> videos = new List<Video>();

            if (!string.IsNullOrEmpty(query))
            {
                videos = await _youTubeService.SearchVideosAsync(query);
            }

            return View(videos);
        }
    }
}

using educa_tube_code.Models;
using educa_tube_code.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace educa_tube_code.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly YouTubeApiService _youTubeService;

        public HomeController(ILogger<HomeController> logger, YouTubeApiService youTubeService)
        {
            _logger = logger;
            _youTubeService = youTubeService;
        }

        public async Task<IActionResult> Index(string query)
        {
            List<Video> searchVideos = new List<Video>();
            List<Video> specificVideos = new List<Video>();

            if (!string.IsNullOrEmpty(query))
            {
                searchVideos = await _youTubeService.SearchVideosAsync(query);
                ViewBag.ShowBanner = false;
            }
            else
            {
                var specificVideoIds = new List<string> { "22nd99SLgNA", "8Z0MdYoZzeM", "kJyQw1k78yg", "kaHwgUCIKFI", "6v0SMTZ8hkU", "OtUuK6nELGg", "EfF1M7myAyY", "4j7hXeZ84iA", "IwNgujjHZoQ"};
                specificVideos = await _youTubeService.GetSpecificVideosAsync(specificVideoIds);
                ViewBag.ShowBanner = true;
            }

            ViewBag.Query = query;
            ViewBag.SpecificVideos = specificVideos;
            return View(searchVideos);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Login");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Watch(string videoId)
        {
            if (string.IsNullOrEmpty(videoId))
            {
                return RedirectToAction("Index");
            }

            var video = new Video
            {
                VideoId = videoId
            };

            return View(video);
        }
    }
}

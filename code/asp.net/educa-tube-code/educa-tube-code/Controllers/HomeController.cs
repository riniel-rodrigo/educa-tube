using educa_tube_code.Models;
using educa_tube_code.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using System.Threading.Tasks;

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
            List<Video> videos = new List<Video>();

            if (!string.IsNullOrEmpty(query))
            {
                videos = await _youTubeService.SearchVideosAsync(query);
            }

            return View(videos);
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
    }
}

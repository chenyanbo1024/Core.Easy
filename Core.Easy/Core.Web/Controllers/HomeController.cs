using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Core.Web.Models;
using Core.IServices;

namespace Core.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBlogServices _blogServices;

        public HomeController(ILogger<HomeController> logger,IBlogServices blogServices)
        {
            _logger = logger;
            _blogServices = blogServices;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult GetBlogList()
        {
            var list = _blogServices.Query();
            return Json(list);
        }
    }
}
